Public Class PersonalTime
    'Array of jobs by default
    Dim activeJoblist As List(Of JobData) = New List(Of JobData)
    Dim activeJobIndex As Integer = 0
    Dim archiveJobList As List(Of JobData) = New List(Of JobData)

    'Currently Displayed ammount of time tracked
    Dim displayTime As Time

    Private Sub AddNewJob_Click(sender As Object, e As EventArgs) Handles AddNewJob.Click
        Dim newJob As JobData = New JobData()
        newJob.name = InputBox("Enter a new job name", "Job Name")
        'only adds the job if the name is not blank
        'TODO: add in a check to make sure the name is unique
        If newJob.name <> "" Then
            JobsList.Items.Add(newJob.name)
            activeJoblist.Add(newJob)
            activeJobIndex = JobsList.Items.Count - 1
            JobsList.SelectedIndex = activeJobIndex
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_closed(sender As Object, e As EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub StartBox_Click(sender As Object, e As EventArgs) Handles StartBox.Click
        If JobsList.Text <> "" Then
            If StartBox.Text = "Start" Then
                StartBox.Text = "Stop"
                StartBox.BackColor = Color.Red
                JobsList.Enabled = False
                AddNewJob.Enabled = False
                ArchiveData.Enabled = False
                DeleteData.Enabled = False

                Timer1.Start()
                activeJoblist(activeJobIndex).startTime()
            Else
                'Changes the GUI back to a usable state
                StartBox.Text = "Start"
                StartBox.BackColor = Color.Green
                JobsList.Enabled = True
                AddNewJob.Enabled = True
                ArchiveData.Enabled = True
                DeleteData.Enabled = True

                'Stops the timer and updates the display
                Timer1.Stop()
                displayTime.reset()

                'Ends the time tracking in the list of jobs
                activeJoblist(activeJobIndex).endTime()
                setTotalTimeTracked()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        displayTime.addMinute()
        CurrentTrackedTime.Text = displayTime.toString()
    End Sub

    Private Sub JobsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobsList.SelectedIndexChanged
        activeJobIndex = JobsList.SelectedIndex
        setTotalTimeTracked()
    End Sub

    Private Sub setTotalTimeTracked()
        TotalTimeTracked.Text = activeJoblist(activeJobIndex).totalTimeTracked.toString()
    End Sub

    Private Sub DeleteData_Click(sender As Object, e As EventArgs) Handles DeleteData.Click
        JobsList.Items.RemoveAt(activeJobIndex)
        DeleteCurrentJob()
    End Sub

    Private Sub ArchiveData_Click(sender As Object, e As EventArgs) Handles ArchiveData.Click
        archiveJobList.Add(activeJoblist(activeJobIndex))
        DeleteCurrentJob()
    End Sub

    Private Sub DeleteCurrentJob()
        JobsList.Items.RemoveAt(activeJobIndex)
        activeJoblist.RemoveAt(activeJobIndex)
        If JobsList.Items.Count = 0 Then
            JobsList.Text = ""
        End If
    End Sub
End Class

Public Class JobData
    Public name As String
    Public totalTimeTracked As Time
    Public timeEntries As List(Of TimeTracked) = New List(Of TimeTracked)
    Dim currentTime As TimeTracked
    Public Sub JobData()
        totalTimeTracked.hours = 0
        totalTimeTracked.minutes = 0
    End Sub
    Public Sub startTime()
        currentTime.startTime = Now
    End Sub
    Public Sub endTime()
        currentTime.endTime = Now
        currentTime.CalculateTime()
        timeEntries.Add(currentTime)
        totalTimeTracked.add(currentTime.timeTracked)
    End Sub
    Public Overrides Function ToString() As String

        Return ""
    End Function

End Class



Public Structure Time
    Public hours As Integer
    Public minutes As Integer
    Public Overrides Function toString() As String
        Dim result As String = hours.ToString
        result += ":"
        If minutes < 10 Then
            result += "0"
        End If
        result += minutes.ToString()
        Return result
    End Function
    Public Sub addMinute()
        minutes += 1
        If minutes >= 60 Then
            minutes = 0
            hours += 1
        End If
    End Sub
    Public Sub add(ByVal addedTime As Time)
        hours += addedTime.hours
        minutes += addedTime.minutes
        If minutes >= 60 Then
            hours += 1
            minutes -= 60
        End If
    End Sub
    Public Sub reset()
        minutes = 0
        hours = 0
    End Sub
End Structure




Public Structure TimeTracked
    Public startTime As Date
    Public endTime As Date
    Public timeTracked As Time
    Public Sub CalculateTime()
        Dim diff As TimeSpan = endTime.Subtract(startTime)
        'timeTracked.minutes = diff.TotalMinutes - diff.TotalHours * 60
        'timeTracked.hours = diff.TotalHours
        'debug
        timeTracked.hours = 1

    End Sub
End Structure