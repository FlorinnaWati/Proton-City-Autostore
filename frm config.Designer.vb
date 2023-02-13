<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_config))
        Me.pbOrder = New System.Windows.Forms.PictureBox()
        Me.pbReport = New System.Windows.Forms.PictureBox()
        Me.pbNewuser = New System.Windows.Forms.PictureBox()
        Me.pbInvoice = New System.Windows.Forms.PictureBox()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.pbClient = New System.Windows.Forms.PictureBox()
        CType(Me.pbOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbOrder
        '
        Me.pbOrder.Image = CType(resources.GetObject("pbOrder.Image"), System.Drawing.Image)
        Me.pbOrder.Location = New System.Drawing.Point(389, 12)
        Me.pbOrder.Name = "pbOrder"
        Me.pbOrder.Size = New System.Drawing.Size(168, 90)
        Me.pbOrder.TabIndex = 0
        Me.pbOrder.TabStop = False
        '
        'pbReport
        '
        Me.pbReport.Image = CType(resources.GetObject("pbReport.Image"), System.Drawing.Image)
        Me.pbReport.Location = New System.Drawing.Point(389, 139)
        Me.pbReport.Name = "pbReport"
        Me.pbReport.Size = New System.Drawing.Size(168, 85)
        Me.pbReport.TabIndex = 1
        Me.pbReport.TabStop = False
        '
        'pbNewuser
        '
        Me.pbNewuser.Image = CType(resources.GetObject("pbNewuser.Image"), System.Drawing.Image)
        Me.pbNewuser.Location = New System.Drawing.Point(201, 139)
        Me.pbNewuser.Name = "pbNewuser"
        Me.pbNewuser.Size = New System.Drawing.Size(164, 85)
        Me.pbNewuser.TabIndex = 2
        Me.pbNewuser.TabStop = False
        '
        'pbInvoice
        '
        Me.pbInvoice.Image = CType(resources.GetObject("pbInvoice.Image"), System.Drawing.Image)
        Me.pbInvoice.Location = New System.Drawing.Point(201, 12)
        Me.pbInvoice.Name = "pbInvoice"
        Me.pbInvoice.Size = New System.Drawing.Size(164, 90)
        Me.pbInvoice.TabIndex = 3
        Me.pbInvoice.TabStop = False
        '
        'pbUser
        '
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(12, 139)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(166, 85)
        Me.pbUser.TabIndex = 4
        Me.pbUser.TabStop = False
        '
        'pbClient
        '
        Me.pbClient.Image = CType(resources.GetObject("pbClient.Image"), System.Drawing.Image)
        Me.pbClient.Location = New System.Drawing.Point(12, 12)
        Me.pbClient.Name = "pbClient"
        Me.pbClient.Size = New System.Drawing.Size(166, 90)
        Me.pbClient.TabIndex = 5
        Me.pbClient.TabStop = False
        '
        'frm_config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 428)
        Me.Controls.Add(Me.pbClient)
        Me.Controls.Add(Me.pbUser)
        Me.Controls.Add(Me.pbInvoice)
        Me.Controls.Add(Me.pbNewuser)
        Me.Controls.Add(Me.pbReport)
        Me.Controls.Add(Me.pbOrder)
        Me.Name = "frm_config"
        Me.Text = "frm_config"
        CType(Me.pbOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbOrder As PictureBox
    Friend WithEvents pbReport As PictureBox
    Friend WithEvents pbNewuser As PictureBox
    Friend WithEvents pbInvoice As PictureBox
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents pbClient As PictureBox
End Class
