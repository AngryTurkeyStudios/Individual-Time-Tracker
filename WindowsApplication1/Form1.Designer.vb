<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalTime
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.JobsList = New System.Windows.Forms.ComboBox()
        Me.AddNewJob = New System.Windows.Forms.Button()
        Me.StartBox = New System.Windows.Forms.Button()
        Me.CurrentTrackedTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ArchiveData = New System.Windows.Forms.Button()
        Me.DeleteData = New System.Windows.Forms.Button()
        Me.TotalTimeTracked = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'JobsList
        '
        Me.JobsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.JobsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.JobsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobsList.FormattingEnabled = True
        Me.JobsList.Location = New System.Drawing.Point(0, 0)
        Me.JobsList.Name = "JobsList"
        Me.JobsList.Size = New System.Drawing.Size(473, 32)
        Me.JobsList.TabIndex = 0
        '
        'AddNewJob
        '
        Me.AddNewJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewJob.Location = New System.Drawing.Point(479, 0)
        Me.AddNewJob.Name = "AddNewJob"
        Me.AddNewJob.Size = New System.Drawing.Size(31, 33)
        Me.AddNewJob.TabIndex = 1
        Me.AddNewJob.Text = "+"
        Me.AddNewJob.UseVisualStyleBackColor = True
        '
        'StartBox
        '
        Me.StartBox.BackColor = System.Drawing.Color.Green
        Me.StartBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartBox.Location = New System.Drawing.Point(0, 39)
        Me.StartBox.Name = "StartBox"
        Me.StartBox.Size = New System.Drawing.Size(122, 73)
        Me.StartBox.TabIndex = 2
        Me.StartBox.Text = "Start"
        Me.StartBox.UseVisualStyleBackColor = False
        '
        'CurrentTrackedTime
        '
        Me.CurrentTrackedTime.AutoSize = True
        Me.CurrentTrackedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTrackedTime.Location = New System.Drawing.Point(128, 39)
        Me.CurrentTrackedTime.Name = "CurrentTrackedTime"
        Me.CurrentTrackedTime.Size = New System.Drawing.Size(194, 73)
        Me.CurrentTrackedTime.TabIndex = 3
        Me.CurrentTrackedTime.Text = "00:00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'ArchiveData
        '
        Me.ArchiveData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveData.Location = New System.Drawing.Point(343, 39)
        Me.ArchiveData.Name = "ArchiveData"
        Me.ArchiveData.Size = New System.Drawing.Size(167, 28)
        Me.ArchiveData.TabIndex = 5
        Me.ArchiveData.Text = "Archive This Project"
        Me.ArchiveData.UseVisualStyleBackColor = True
        '
        'DeleteData
        '
        Me.DeleteData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteData.Location = New System.Drawing.Point(343, 73)
        Me.DeleteData.Name = "DeleteData"
        Me.DeleteData.Size = New System.Drawing.Size(167, 28)
        Me.DeleteData.TabIndex = 6
        Me.DeleteData.Text = "Delete This Project"
        Me.DeleteData.UseVisualStyleBackColor = True
        '
        'TotalTimeTracked
        '
        Me.TotalTimeTracked.AutoSize = True
        Me.TotalTimeTracked.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTimeTracked.Location = New System.Drawing.Point(134, 112)
        Me.TotalTimeTracked.Name = "TotalTimeTracked"
        Me.TotalTimeTracked.Size = New System.Drawing.Size(98, 37)
        Me.TotalTimeTracked.TabIndex = 7
        Me.TotalTimeTracked.Text = "00:00"
        '
        'PersonalTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 261)
        Me.Controls.Add(Me.TotalTimeTracked)
        Me.Controls.Add(Me.DeleteData)
        Me.Controls.Add(Me.ArchiveData)
        Me.Controls.Add(Me.CurrentTrackedTime)
        Me.Controls.Add(Me.StartBox)
        Me.Controls.Add(Me.AddNewJob)
        Me.Controls.Add(Me.JobsList)
        Me.Name = "PersonalTime"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents JobsList As ComboBox
    Friend WithEvents AddNewJob As Button
    Friend WithEvents StartBox As Button
    Friend WithEvents CurrentTrackedTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ArchiveData As Button
    Friend WithEvents DeleteData As Button
    Friend WithEvents TotalTimeTracked As Label
End Class
