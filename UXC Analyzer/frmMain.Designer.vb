<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblBeforeVideoLength = New System.Windows.Forms.Label()
        Me.btnBeforeEventEnd = New System.Windows.Forms.Button()
        Me.btnBeforeEventStart = New System.Windows.Forms.Button()
        Me.vidBefore = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnBeforePlay2Pixel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBeforeRefresh = New System.Windows.Forms.Button()
        Me.txtBeforeVidTimer = New System.Windows.Forms.MaskedTextBox()
        Me.txtBeforeInterval = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBeforeMarkPixel = New System.Windows.Forms.Button()
        Me.btnBeforePlay = New System.Windows.Forms.Button()
        Me.btnBeforePause = New System.Windows.Forms.Button()
        Me.btnBeforeStepNext = New System.Windows.Forms.Button()
        Me.btnBeforeMoveLast = New System.Windows.Forms.Button()
        Me.btnBeforeStepPrev = New System.Windows.Forms.Button()
        Me.btnBeforeMoveFirst = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblAfterVideoLength = New System.Windows.Forms.Label()
        Me.btnAfterEventEnd = New System.Windows.Forms.Button()
        Me.btnAfterEventStart = New System.Windows.Forms.Button()
        Me.btnAfterPlay2Pixel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAfterVidTimer = New System.Windows.Forms.MaskedTextBox()
        Me.txtAfterInterval = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vidAfter = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnAfterRefresh = New System.Windows.Forms.Button()
        Me.btnAfterMarkPixel = New System.Windows.Forms.Button()
        Me.btnAfterPlay = New System.Windows.Forms.Button()
        Me.btnAfterPause = New System.Windows.Forms.Button()
        Me.btnAfterStepNext = New System.Windows.Forms.Button()
        Me.btnAfterMoveLast = New System.Windows.Forms.Button()
        Me.btnAfterStepPrev = New System.Windows.Forms.Button()
        Me.btnAfterMoveFirst = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenBeforeVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenBeforeVideoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAfterVideoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseBeforeVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseBeforeVideoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAfterVideoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenEventListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveEventListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgEventList = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip7 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip8 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip9 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtEventDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEventTimeDifference = New System.Windows.Forms.Label()
        Me.lblx = New System.Windows.Forms.Label()
        Me.lblEventPctDifference = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.ToolTip10 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip11 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip12 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip13 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip14 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip15 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip16 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip17 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip18 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip19 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip20 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip21 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip22 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBeforeEventDuration = New System.Windows.Forms.Label()
        Me.lblBeforeEventEnd = New System.Windows.Forms.Label()
        Me.lblBeforeEventStart = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAfterEventDuration = New System.Windows.Forms.Label()
        Me.lblAfterEventEnd = New System.Windows.Forms.Label()
        Me.lblAfterEventStart = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.btnClearValues = New System.Windows.Forms.Button()
        Me.ToolTip23 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip24 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Event_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Before_Event_Start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Before_Event_End = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Before_Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.After_Event_Start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.After_Event_End = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.After_Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time_Difference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Percent_Difference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.vidBefore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.vidAfter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgEventList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(828, 564)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblBeforeVideoLength)
        Me.TabPage1.Controls.Add(Me.btnBeforeEventEnd)
        Me.TabPage1.Controls.Add(Me.btnBeforeEventStart)
        Me.TabPage1.Controls.Add(Me.vidBefore)
        Me.TabPage1.Controls.Add(Me.btnBeforePlay2Pixel)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnBeforeRefresh)
        Me.TabPage1.Controls.Add(Me.txtBeforeVidTimer)
        Me.TabPage1.Controls.Add(Me.txtBeforeInterval)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnBeforeMarkPixel)
        Me.TabPage1.Controls.Add(Me.btnBeforePlay)
        Me.TabPage1.Controls.Add(Me.btnBeforePause)
        Me.TabPage1.Controls.Add(Me.btnBeforeStepNext)
        Me.TabPage1.Controls.Add(Me.btnBeforeMoveLast)
        Me.TabPage1.Controls.Add(Me.btnBeforeStepPrev)
        Me.TabPage1.Controls.Add(Me.btnBeforeMoveFirst)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(820, 538)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Before"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblBeforeVideoLength
        '
        Me.lblBeforeVideoLength.AutoSize = True
        Me.lblBeforeVideoLength.Location = New System.Drawing.Point(342, 518)
        Me.lblBeforeVideoLength.Name = "lblBeforeVideoLength"
        Me.lblBeforeVideoLength.Size = New System.Drawing.Size(46, 13)
        Me.lblBeforeVideoLength.TabIndex = 45
        Me.lblBeforeVideoLength.Text = "of 000.0"
        '
        'btnBeforeEventEnd
        '
        Me.btnBeforeEventEnd.BackgroundImage = CType(resources.GetObject("btnBeforeEventEnd.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforeEventEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeEventEnd.Location = New System.Drawing.Point(776, 98)
        Me.btnBeforeEventEnd.Name = "btnBeforeEventEnd"
        Me.btnBeforeEventEnd.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforeEventEnd.TabIndex = 44
        Me.btnBeforeEventEnd.UseVisualStyleBackColor = True
        '
        'btnBeforeEventStart
        '
        Me.btnBeforeEventStart.BackgroundImage = CType(resources.GetObject("btnBeforeEventStart.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforeEventStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeEventStart.Location = New System.Drawing.Point(776, 44)
        Me.btnBeforeEventStart.Name = "btnBeforeEventStart"
        Me.btnBeforeEventStart.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforeEventStart.TabIndex = 43
        Me.btnBeforeEventStart.UseVisualStyleBackColor = True
        '
        'vidBefore
        '
        Me.vidBefore.Enabled = True
        Me.vidBefore.Location = New System.Drawing.Point(1, 1)
        Me.vidBefore.Name = "vidBefore"
        Me.vidBefore.OcxState = CType(resources.GetObject("vidBefore.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vidBefore.Size = New System.Drawing.Size(769, 483)
        Me.vidBefore.TabIndex = 14
        '
        'btnBeforePlay2Pixel
        '
        Me.btnBeforePlay2Pixel.BackgroundImage = CType(resources.GetObject("btnBeforePlay2Pixel.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforePlay2Pixel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforePlay2Pixel.Location = New System.Drawing.Point(607, 490)
        Me.btnBeforePlay2Pixel.Name = "btnBeforePlay2Pixel"
        Me.btnBeforePlay2Pixel.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforePlay2Pixel.TabIndex = 42
        Me.btnBeforePlay2Pixel.Tag = "Play to Pixel Change"
        Me.btnBeforePlay2Pixel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Video Counter:"
        '
        'btnBeforeRefresh
        '
        Me.btnBeforeRefresh.BackgroundImage = CType(resources.GetObject("btnBeforeRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforeRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeRefresh.Location = New System.Drawing.Point(414, 491)
        Me.btnBeforeRefresh.Name = "btnBeforeRefresh"
        Me.btnBeforeRefresh.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforeRefresh.TabIndex = 40
        Me.btnBeforeRefresh.Tag = "Refresh"
        Me.btnBeforeRefresh.UseVisualStyleBackColor = True
        '
        'txtBeforeVidTimer
        '
        Me.txtBeforeVidTimer.Location = New System.Drawing.Point(301, 513)
        Me.txtBeforeVidTimer.Mask = "###.#"
        Me.txtBeforeVidTimer.Name = "txtBeforeVidTimer"
        Me.txtBeforeVidTimer.Size = New System.Drawing.Size(38, 20)
        Me.txtBeforeVidTimer.TabIndex = 39
        Me.txtBeforeVidTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBeforeInterval
        '
        Me.txtBeforeInterval.Location = New System.Drawing.Point(486, 511)
        Me.txtBeforeInterval.Mask = "##.#"
        Me.txtBeforeInterval.Name = "txtBeforeInterval"
        Me.txtBeforeInterval.Size = New System.Drawing.Size(33, 20)
        Me.txtBeforeInterval.TabIndex = 38
        Me.txtBeforeInterval.Text = "001"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(469, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Step Interval:"
        '
        'btnBeforeMarkPixel
        '
        Me.btnBeforeMarkPixel.BackgroundImage = CType(resources.GetObject("btnBeforeMarkPixel.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforeMarkPixel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeMarkPixel.Location = New System.Drawing.Point(652, 490)
        Me.btnBeforeMarkPixel.Name = "btnBeforeMarkPixel"
        Me.btnBeforeMarkPixel.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforeMarkPixel.TabIndex = 36
        Me.btnBeforeMarkPixel.Tag = "Mark Pixel Cluster"
        Me.btnBeforeMarkPixel.UseVisualStyleBackColor = True
        '
        'btnBeforePlay
        '
        Me.btnBeforePlay.BackgroundImage = CType(resources.GetObject("btnBeforePlay.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforePlay.Location = New System.Drawing.Point(142, 492)
        Me.btnBeforePlay.Name = "btnBeforePlay"
        Me.btnBeforePlay.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforePlay.TabIndex = 35
        Me.btnBeforePlay.Tag = "Play"
        Me.btnBeforePlay.UseVisualStyleBackColor = True
        '
        'btnBeforePause
        '
        Me.btnBeforePause.BackgroundImage = CType(resources.GetObject("btnBeforePause.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforePause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforePause.Location = New System.Drawing.Point(97, 491)
        Me.btnBeforePause.Name = "btnBeforePause"
        Me.btnBeforePause.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforePause.TabIndex = 34
        Me.btnBeforePause.Tag = "Pause"
        Me.btnBeforePause.UseVisualStyleBackColor = True
        '
        'btnBeforeStepNext
        '
        Me.btnBeforeStepNext.BackgroundImage = CType(resources.GetObject("btnBeforeStepNext.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforeStepNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeStepNext.Location = New System.Drawing.Point(187, 491)
        Me.btnBeforeStepNext.Name = "btnBeforeStepNext"
        Me.btnBeforeStepNext.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforeStepNext.TabIndex = 33
        Me.btnBeforeStepNext.Tag = "Step Next"
        Me.btnBeforeStepNext.UseVisualStyleBackColor = True
        '
        'btnBeforeMoveLast
        '
        Me.btnBeforeMoveLast.BackgroundImage = CType(resources.GetObject("btnBeforeMoveLast.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforeMoveLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeMoveLast.Location = New System.Drawing.Point(232, 490)
        Me.btnBeforeMoveLast.Name = "btnBeforeMoveLast"
        Me.btnBeforeMoveLast.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforeMoveLast.TabIndex = 32
        Me.btnBeforeMoveLast.Tag = "Move to End"
        Me.btnBeforeMoveLast.UseVisualStyleBackColor = True
        '
        'btnBeforeStepPrev
        '
        Me.btnBeforeStepPrev.BackgroundImage = CType(resources.GetObject("btnBeforeStepPrev.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforeStepPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeStepPrev.Location = New System.Drawing.Point(51, 491)
        Me.btnBeforeStepPrev.Name = "btnBeforeStepPrev"
        Me.btnBeforeStepPrev.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforeStepPrev.TabIndex = 31
        Me.btnBeforeStepPrev.Tag = "Step Previous"
        Me.btnBeforeStepPrev.UseVisualStyleBackColor = True
        '
        'btnBeforeMoveFirst
        '
        Me.btnBeforeMoveFirst.BackgroundImage = CType(resources.GetObject("btnBeforeMoveFirst.BackgroundImage"), System.Drawing.Image)
        Me.btnBeforeMoveFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeMoveFirst.Location = New System.Drawing.Point(6, 491)
        Me.btnBeforeMoveFirst.Name = "btnBeforeMoveFirst"
        Me.btnBeforeMoveFirst.Size = New System.Drawing.Size(39, 42)
        Me.btnBeforeMoveFirst.TabIndex = 30
        Me.btnBeforeMoveFirst.Tag = "Move to Start"
        Me.btnBeforeMoveFirst.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblAfterVideoLength)
        Me.TabPage2.Controls.Add(Me.btnAfterEventEnd)
        Me.TabPage2.Controls.Add(Me.btnAfterEventStart)
        Me.TabPage2.Controls.Add(Me.btnAfterPlay2Pixel)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtAfterVidTimer)
        Me.TabPage2.Controls.Add(Me.txtAfterInterval)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.vidAfter)
        Me.TabPage2.Controls.Add(Me.btnAfterRefresh)
        Me.TabPage2.Controls.Add(Me.btnAfterMarkPixel)
        Me.TabPage2.Controls.Add(Me.btnAfterPlay)
        Me.TabPage2.Controls.Add(Me.btnAfterPause)
        Me.TabPage2.Controls.Add(Me.btnAfterStepNext)
        Me.TabPage2.Controls.Add(Me.btnAfterMoveLast)
        Me.TabPage2.Controls.Add(Me.btnAfterStepPrev)
        Me.TabPage2.Controls.Add(Me.btnAfterMoveFirst)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(820, 538)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "After"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblAfterVideoLength
        '
        Me.lblAfterVideoLength.AutoSize = True
        Me.lblAfterVideoLength.Location = New System.Drawing.Point(342, 518)
        Me.lblAfterVideoLength.Name = "lblAfterVideoLength"
        Me.lblAfterVideoLength.Size = New System.Drawing.Size(46, 13)
        Me.lblAfterVideoLength.TabIndex = 49
        Me.lblAfterVideoLength.Text = "of 000.0"
        '
        'btnAfterEventEnd
        '
        Me.btnAfterEventEnd.BackgroundImage = CType(resources.GetObject("btnAfterEventEnd.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterEventEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterEventEnd.Location = New System.Drawing.Point(776, 287)
        Me.btnAfterEventEnd.Name = "btnAfterEventEnd"
        Me.btnAfterEventEnd.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterEventEnd.TabIndex = 48
        Me.btnAfterEventEnd.UseVisualStyleBackColor = True
        '
        'btnAfterEventStart
        '
        Me.btnAfterEventStart.BackgroundImage = CType(resources.GetObject("btnAfterEventStart.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterEventStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterEventStart.Location = New System.Drawing.Point(776, 233)
        Me.btnAfterEventStart.Name = "btnAfterEventStart"
        Me.btnAfterEventStart.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterEventStart.TabIndex = 47
        Me.btnAfterEventStart.UseVisualStyleBackColor = True
        '
        'btnAfterPlay2Pixel
        '
        Me.btnAfterPlay2Pixel.BackgroundImage = CType(resources.GetObject("btnAfterPlay2Pixel.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterPlay2Pixel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterPlay2Pixel.Location = New System.Drawing.Point(607, 490)
        Me.btnAfterPlay2Pixel.Name = "btnAfterPlay2Pixel"
        Me.btnAfterPlay2Pixel.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterPlay2Pixel.TabIndex = 42
        Me.btnAfterPlay2Pixel.Tag = "Play to Pixel Change"
        Me.btnAfterPlay2Pixel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Video Counter:"
        '
        'txtAfterVidTimer
        '
        Me.txtAfterVidTimer.Location = New System.Drawing.Point(301, 513)
        Me.txtAfterVidTimer.Mask = "###.#"
        Me.txtAfterVidTimer.Name = "txtAfterVidTimer"
        Me.txtAfterVidTimer.Size = New System.Drawing.Size(38, 20)
        Me.txtAfterVidTimer.TabIndex = 39
        '
        'txtAfterInterval
        '
        Me.txtAfterInterval.Location = New System.Drawing.Point(486, 511)
        Me.txtAfterInterval.Mask = "##.#"
        Me.txtAfterInterval.Name = "txtAfterInterval"
        Me.txtAfterInterval.Size = New System.Drawing.Size(33, 20)
        Me.txtAfterInterval.TabIndex = 38
        Me.txtAfterInterval.Text = "001"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 495)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Step Interval:"
        '
        'vidAfter
        '
        Me.vidAfter.Enabled = True
        Me.vidAfter.Location = New System.Drawing.Point(1, 1)
        Me.vidAfter.Name = "vidAfter"
        Me.vidAfter.OcxState = CType(resources.GetObject("vidAfter.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vidAfter.Size = New System.Drawing.Size(769, 484)
        Me.vidAfter.TabIndex = 24
        '
        'btnAfterRefresh
        '
        Me.btnAfterRefresh.BackgroundImage = CType(resources.GetObject("btnAfterRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterRefresh.Location = New System.Drawing.Point(414, 491)
        Me.btnAfterRefresh.Name = "btnAfterRefresh"
        Me.btnAfterRefresh.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterRefresh.TabIndex = 40
        Me.btnAfterRefresh.Tag = "Refresh"
        Me.btnAfterRefresh.UseVisualStyleBackColor = True
        '
        'btnAfterMarkPixel
        '
        Me.btnAfterMarkPixel.BackgroundImage = CType(resources.GetObject("btnAfterMarkPixel.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterMarkPixel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterMarkPixel.Location = New System.Drawing.Point(652, 490)
        Me.btnAfterMarkPixel.Name = "btnAfterMarkPixel"
        Me.btnAfterMarkPixel.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterMarkPixel.TabIndex = 36
        Me.btnAfterMarkPixel.Tag = "Mark Pixel Cluster"
        Me.btnAfterMarkPixel.UseVisualStyleBackColor = True
        '
        'btnAfterPlay
        '
        Me.btnAfterPlay.BackgroundImage = CType(resources.GetObject("btnAfterPlay.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterPlay.Location = New System.Drawing.Point(142, 492)
        Me.btnAfterPlay.Name = "btnAfterPlay"
        Me.btnAfterPlay.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterPlay.TabIndex = 35
        Me.btnAfterPlay.Tag = "Play"
        Me.btnAfterPlay.UseVisualStyleBackColor = True
        '
        'btnAfterPause
        '
        Me.btnAfterPause.BackgroundImage = CType(resources.GetObject("btnAfterPause.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterPause.Location = New System.Drawing.Point(97, 491)
        Me.btnAfterPause.Name = "btnAfterPause"
        Me.btnAfterPause.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterPause.TabIndex = 34
        Me.btnAfterPause.Tag = "Pause"
        Me.btnAfterPause.UseVisualStyleBackColor = True
        '
        'btnAfterStepNext
        '
        Me.btnAfterStepNext.BackgroundImage = CType(resources.GetObject("btnAfterStepNext.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterStepNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterStepNext.Location = New System.Drawing.Point(187, 491)
        Me.btnAfterStepNext.Name = "btnAfterStepNext"
        Me.btnAfterStepNext.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterStepNext.TabIndex = 33
        Me.btnAfterStepNext.Tag = "Step Next"
        Me.btnAfterStepNext.UseVisualStyleBackColor = True
        '
        'btnAfterMoveLast
        '
        Me.btnAfterMoveLast.BackgroundImage = CType(resources.GetObject("btnAfterMoveLast.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterMoveLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterMoveLast.Location = New System.Drawing.Point(232, 490)
        Me.btnAfterMoveLast.Name = "btnAfterMoveLast"
        Me.btnAfterMoveLast.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterMoveLast.TabIndex = 32
        Me.btnAfterMoveLast.Tag = "Move to End"
        Me.btnAfterMoveLast.UseVisualStyleBackColor = True
        '
        'btnAfterStepPrev
        '
        Me.btnAfterStepPrev.BackgroundImage = CType(resources.GetObject("btnAfterStepPrev.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterStepPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterStepPrev.Location = New System.Drawing.Point(51, 491)
        Me.btnAfterStepPrev.Name = "btnAfterStepPrev"
        Me.btnAfterStepPrev.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterStepPrev.TabIndex = 31
        Me.btnAfterStepPrev.Tag = "Step Previous"
        Me.btnAfterStepPrev.UseVisualStyleBackColor = True
        '
        'btnAfterMoveFirst
        '
        Me.btnAfterMoveFirst.BackgroundImage = CType(resources.GetObject("btnAfterMoveFirst.BackgroundImage"), System.Drawing.Image)
        Me.btnAfterMoveFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAfterMoveFirst.Location = New System.Drawing.Point(6, 491)
        Me.btnAfterMoveFirst.Name = "btnAfterMoveFirst"
        Me.btnAfterMoveFirst.Size = New System.Drawing.Size(39, 42)
        Me.btnAfterMoveFirst.TabIndex = 30
        Me.btnAfterMoveFirst.Tag = "Move to Start"
        Me.btnAfterMoveFirst.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EventListToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenBeforeVideoToolStripMenuItem, Me.CloseBeforeVideoToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenBeforeVideoToolStripMenuItem
        '
        Me.OpenBeforeVideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenBeforeVideoToolStripMenuItem1, Me.OpenAfterVideoToolStripMenuItem1})
        Me.OpenBeforeVideoToolStripMenuItem.Image = Global.UXC_Analyzer.My.Resources.Resources.OpenFolder
        Me.OpenBeforeVideoToolStripMenuItem.Name = "OpenBeforeVideoToolStripMenuItem"
        Me.OpenBeforeVideoToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.OpenBeforeVideoToolStripMenuItem.Text = "Open Video"
        '
        'OpenBeforeVideoToolStripMenuItem1
        '
        Me.OpenBeforeVideoToolStripMenuItem1.Name = "OpenBeforeVideoToolStripMenuItem1"
        Me.OpenBeforeVideoToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.OpenBeforeVideoToolStripMenuItem1.Text = "Open ""Before"" Video..."
        '
        'OpenAfterVideoToolStripMenuItem1
        '
        Me.OpenAfterVideoToolStripMenuItem1.Name = "OpenAfterVideoToolStripMenuItem1"
        Me.OpenAfterVideoToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.OpenAfterVideoToolStripMenuItem1.Text = "Open ""After"" Video..."
        '
        'CloseBeforeVideoToolStripMenuItem
        '
        Me.CloseBeforeVideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseBeforeVideoToolStripMenuItem1, Me.CloseAfterVideoToolStripMenuItem1})
        Me.CloseBeforeVideoToolStripMenuItem.Image = CType(resources.GetObject("CloseBeforeVideoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseBeforeVideoToolStripMenuItem.Name = "CloseBeforeVideoToolStripMenuItem"
        Me.CloseBeforeVideoToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CloseBeforeVideoToolStripMenuItem.Text = "Close Video"
        '
        'CloseBeforeVideoToolStripMenuItem1
        '
        Me.CloseBeforeVideoToolStripMenuItem1.Name = "CloseBeforeVideoToolStripMenuItem1"
        Me.CloseBeforeVideoToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.CloseBeforeVideoToolStripMenuItem1.Text = "Close ""Before"" Video"
        '
        'CloseAfterVideoToolStripMenuItem1
        '
        Me.CloseAfterVideoToolStripMenuItem1.Name = "CloseAfterVideoToolStripMenuItem1"
        Me.CloseAfterVideoToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.CloseAfterVideoToolStripMenuItem1.Text = "Close ""After"" Video"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EventListToolStripMenuItem
        '
        Me.EventListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenEventListToolStripMenuItem, Me.SaveEventListToolStripMenuItem})
        Me.EventListToolStripMenuItem.Name = "EventListToolStripMenuItem"
        Me.EventListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EventListToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EventListToolStripMenuItem.Text = "&Event List"
        '
        'OpenEventListToolStripMenuItem
        '
        Me.OpenEventListToolStripMenuItem.Name = "OpenEventListToolStripMenuItem"
        Me.OpenEventListToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OpenEventListToolStripMenuItem.Text = "Open Event List..."
        '
        'SaveEventListToolStripMenuItem
        '
        Me.SaveEventListToolStripMenuItem.Name = "SaveEventListToolStripMenuItem"
        Me.SaveEventListToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SaveEventListToolStripMenuItem.Text = "Save Event List..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'dgEventList
        '
        Me.dgEventList.AllowUserToOrderColumns = True
        Me.dgEventList.AllowUserToResizeColumns = False
        Me.dgEventList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEventList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEventList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Event_ID, Me.Event_Name, Me.Before_Event_Start, Me.Before_Event_End, Me.Before_Duration, Me.After_Event_Start, Me.After_Event_End, Me.After_Duration, Me.Time_Difference, Me.Percent_Difference})
        Me.dgEventList.Location = New System.Drawing.Point(12, 597)
        Me.dgEventList.MultiSelect = False
        Me.dgEventList.Name = "dgEventList"
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEventList.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgEventList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgEventList.ShowCellErrors = False
        Me.dgEventList.ShowRowErrors = False
        Me.dgEventList.Size = New System.Drawing.Size(984, 130)
        Me.dgEventList.TabIndex = 2
        '
        'txtEventDescription
        '
        Me.txtEventDescription.Location = New System.Drawing.Point(849, 53)
        Me.txtEventDescription.Name = "txtEventDescription"
        Me.txtEventDescription.Size = New System.Drawing.Size(151, 20)
        Me.txtEventDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(849, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Event Description"
        '
        'lblEventTimeDifference
        '
        Me.lblEventTimeDifference.AutoSize = True
        Me.lblEventTimeDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEventTimeDifference.Location = New System.Drawing.Point(869, 466)
        Me.lblEventTimeDifference.MinimumSize = New System.Drawing.Size(39, 15)
        Me.lblEventTimeDifference.Name = "lblEventTimeDifference"
        Me.lblEventTimeDifference.Size = New System.Drawing.Size(39, 15)
        Me.lblEventTimeDifference.TabIndex = 18
        Me.lblEventTimeDifference.Text = "-000.0"
        Me.lblEventTimeDifference.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Location = New System.Drawing.Point(849, 448)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(113, 13)
        Me.lblx.TabIndex = 17
        Me.lblx.Text = "Event Time Difference"
        '
        'lblEventPctDifference
        '
        Me.lblEventPctDifference.AutoSize = True
        Me.lblEventPctDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEventPctDifference.Location = New System.Drawing.Point(869, 511)
        Me.lblEventPctDifference.MinimumSize = New System.Drawing.Size(42, 13)
        Me.lblEventPctDifference.Name = "lblEventPctDifference"
        Me.lblEventPctDifference.Size = New System.Drawing.Size(44, 15)
        Me.lblEventPctDifference.TabIndex = 20
        Me.lblEventPctDifference.Text = "000.0%"
        Me.lblEventPctDifference.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbly
        '
        Me.lbly.AutoSize = True
        Me.lbly.Location = New System.Drawing.Point(849, 493)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(98, 13)
        Me.lbly.TabIndex = 19
        Me.lbly.Text = "Event % Difference"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBeforeEventDuration)
        Me.GroupBox1.Controls.Add(Me.lblBeforeEventEnd)
        Me.GroupBox1.Controls.Add(Me.lblBeforeEventStart)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(846, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 171)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = """Before"" Event"
        '
        'lblBeforeEventDuration
        '
        Me.lblBeforeEventDuration.AutoSize = True
        Me.lblBeforeEventDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeforeEventDuration.Location = New System.Drawing.Point(36, 142)
        Me.lblBeforeEventDuration.MinimumSize = New System.Drawing.Size(34, 13)
        Me.lblBeforeEventDuration.Name = "lblBeforeEventDuration"
        Me.lblBeforeEventDuration.Size = New System.Drawing.Size(36, 15)
        Me.lblBeforeEventDuration.TabIndex = 19
        Me.lblBeforeEventDuration.Text = "000.0"
        Me.lblBeforeEventDuration.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBeforeEventEnd
        '
        Me.lblBeforeEventEnd.AutoSize = True
        Me.lblBeforeEventEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeforeEventEnd.Location = New System.Drawing.Point(36, 85)
        Me.lblBeforeEventEnd.MinimumSize = New System.Drawing.Size(34, 13)
        Me.lblBeforeEventEnd.Name = "lblBeforeEventEnd"
        Me.lblBeforeEventEnd.Size = New System.Drawing.Size(36, 15)
        Me.lblBeforeEventEnd.TabIndex = 18
        Me.lblBeforeEventEnd.Text = "000.0"
        Me.lblBeforeEventEnd.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBeforeEventStart
        '
        Me.lblBeforeEventStart.AutoSize = True
        Me.lblBeforeEventStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeforeEventStart.Location = New System.Drawing.Point(36, 31)
        Me.lblBeforeEventStart.MinimumSize = New System.Drawing.Size(34, 13)
        Me.lblBeforeEventStart.Name = "lblBeforeEventStart"
        Me.lblBeforeEventStart.Size = New System.Drawing.Size(36, 15)
        Me.lblBeforeEventStart.TabIndex = 17
        Me.lblBeforeEventStart.Text = "000.0"
        Me.lblBeforeEventStart.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Event Duration"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Event End"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Event Start"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAfterEventDuration)
        Me.GroupBox2.Controls.Add(Me.lblAfterEventEnd)
        Me.GroupBox2.Controls.Add(Me.lblAfterEventStart)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(846, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 168)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = """After"" Event"
        '
        'lblAfterEventDuration
        '
        Me.lblAfterEventDuration.AutoSize = True
        Me.lblAfterEventDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAfterEventDuration.Location = New System.Drawing.Point(36, 145)
        Me.lblAfterEventDuration.MinimumSize = New System.Drawing.Size(34, 13)
        Me.lblAfterEventDuration.Name = "lblAfterEventDuration"
        Me.lblAfterEventDuration.Size = New System.Drawing.Size(36, 15)
        Me.lblAfterEventDuration.TabIndex = 22
        Me.lblAfterEventDuration.Text = "000.0"
        Me.lblAfterEventDuration.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAfterEventEnd
        '
        Me.lblAfterEventEnd.AutoSize = True
        Me.lblAfterEventEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAfterEventEnd.Location = New System.Drawing.Point(36, 89)
        Me.lblAfterEventEnd.MinimumSize = New System.Drawing.Size(34, 13)
        Me.lblAfterEventEnd.Name = "lblAfterEventEnd"
        Me.lblAfterEventEnd.Size = New System.Drawing.Size(36, 15)
        Me.lblAfterEventEnd.TabIndex = 21
        Me.lblAfterEventEnd.Text = "000.0"
        Me.lblAfterEventEnd.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAfterEventStart
        '
        Me.lblAfterEventStart.AutoSize = True
        Me.lblAfterEventStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAfterEventStart.Location = New System.Drawing.Point(36, 35)
        Me.lblAfterEventStart.MinimumSize = New System.Drawing.Size(34, 13)
        Me.lblAfterEventStart.Name = "lblAfterEventStart"
        Me.lblAfterEventStart.Size = New System.Drawing.Size(36, 15)
        Me.lblAfterEventStart.TabIndex = 20
        Me.lblAfterEventStart.Text = "000.0"
        Me.lblAfterEventStart.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Event Duration"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Event End"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Event Start"
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Image = CType(resources.GetObject("btnSaveEvent.Image"), System.Drawing.Image)
        Me.btnSaveEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveEvent.Location = New System.Drawing.Point(849, 536)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(151, 25)
        Me.btnSaveEvent.TabIndex = 21
        Me.btnSaveEvent.Text = "Save Event"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'btnClearValues
        '
        Me.btnClearValues.BackgroundImage = CType(resources.GetObject("btnClearValues.BackgroundImage"), System.Drawing.Image)
        Me.btnClearValues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearValues.Location = New System.Drawing.Point(961, 491)
        Me.btnClearValues.Name = "btnClearValues"
        Me.btnClearValues.Size = New System.Drawing.Size(39, 42)
        Me.btnClearValues.TabIndex = 37
        Me.btnClearValues.Tag = "Mark Pixel Cluster"
        Me.btnClearValues.UseVisualStyleBackColor = True
        '
        'Event_ID
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.Event_ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.Event_ID.HeaderText = "#"
        Me.Event_ID.MaxInputLength = 3
        Me.Event_ID.Name = "Event_ID"
        Me.Event_ID.ReadOnly = True
        Me.Event_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Event_ID.Width = 40
        '
        'Event_Name
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.Event_Name.DefaultCellStyle = DataGridViewCellStyle3
        Me.Event_Name.HeaderText = "Event Name"
        Me.Event_Name.Name = "Event_Name"
        Me.Event_Name.Width = 350
        '
        'Before_Event_Start
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Before_Event_Start.DefaultCellStyle = DataGridViewCellStyle4
        Me.Before_Event_Start.HeaderText = "Event Start"
        Me.Before_Event_Start.Name = "Before_Event_Start"
        Me.Before_Event_Start.Width = 65
        '
        'Before_Event_End
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Before_Event_End.DefaultCellStyle = DataGridViewCellStyle5
        Me.Before_Event_End.HeaderText = "Event End"
        Me.Before_Event_End.Name = "Before_Event_End"
        Me.Before_Event_End.Width = 65
        '
        'Before_Duration
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Before_Duration.DefaultCellStyle = DataGridViewCellStyle6
        Me.Before_Duration.HeaderText = """Before"" Duration"
        Me.Before_Duration.Name = "Before_Duration"
        Me.Before_Duration.Width = 65
        '
        'After_Event_Start
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.After_Event_Start.DefaultCellStyle = DataGridViewCellStyle7
        Me.After_Event_Start.HeaderText = "Event Start"
        Me.After_Event_Start.Name = "After_Event_Start"
        Me.After_Event_Start.Width = 65
        '
        'After_Event_End
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.After_Event_End.DefaultCellStyle = DataGridViewCellStyle8
        Me.After_Event_End.HeaderText = "Event End"
        Me.After_Event_End.Name = "After_Event_End"
        Me.After_Event_End.Width = 65
        '
        'After_Duration
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.After_Duration.DefaultCellStyle = DataGridViewCellStyle9
        Me.After_Duration.HeaderText = """After"" Duration"
        Me.After_Duration.Name = "After_Duration"
        Me.After_Duration.Width = 65
        '
        'Time_Difference
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Time_Difference.DefaultCellStyle = DataGridViewCellStyle10
        Me.Time_Difference.HeaderText = "Time Difference"
        Me.Time_Difference.Name = "Time_Difference"
        Me.Time_Difference.Width = 65
        '
        'Percent_Difference
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Percent_Difference.DefaultCellStyle = DataGridViewCellStyle11
        Me.Percent_Difference.HeaderText = "% Difference"
        Me.Percent_Difference.Name = "Percent_Difference"
        Me.Percent_Difference.Width = 70
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.btnClearValues)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.Controls.Add(Me.lblEventPctDifference)
        Me.Controls.Add(Me.lbly)
        Me.Controls.Add(Me.lblEventTimeDifference)
        Me.Controls.Add(Me.lblx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEventDescription)
        Me.Controls.Add(Me.dgEventList)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UXC Analyzer"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.vidBefore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.vidAfter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgEventList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgEventList As System.Windows.Forms.DataGridView
    Friend WithEvents OpenBeforeVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseBeforeVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents vidBefore As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents vidAfter As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnAfterPlay2Pixel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAfterRefresh As System.Windows.Forms.Button
    Friend WithEvents txtAfterVidTimer As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAfterInterval As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAfterMarkPixel As System.Windows.Forms.Button
    Friend WithEvents btnAfterPlay As System.Windows.Forms.Button
    Friend WithEvents btnAfterPause As System.Windows.Forms.Button
    Friend WithEvents btnAfterStepNext As System.Windows.Forms.Button
    Friend WithEvents btnAfterMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnAfterStepPrev As System.Windows.Forms.Button
    Friend WithEvents btnAfterMoveFirst As System.Windows.Forms.Button
    Friend WithEvents btnBeforePlay2Pixel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBeforeRefresh As System.Windows.Forms.Button
    Friend WithEvents txtBeforeVidTimer As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBeforeInterval As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBeforePlay As System.Windows.Forms.Button
    Friend WithEvents btnBeforePause As System.Windows.Forms.Button
    Friend WithEvents btnBeforeStepNext As System.Windows.Forms.Button
    Friend WithEvents btnBeforeMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnBeforeStepPrev As System.Windows.Forms.Button
    Friend WithEvents btnBeforeMoveFirst As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip5 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip6 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip7 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip8 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip9 As System.Windows.Forms.ToolTip
    Friend WithEvents btnBeforeEventEnd As System.Windows.Forms.Button
    Friend WithEvents btnBeforeEventStart As System.Windows.Forms.Button
    Friend WithEvents btnAfterEventEnd As System.Windows.Forms.Button
    Friend WithEvents btnAfterEventStart As System.Windows.Forms.Button
    Friend WithEvents txtEventDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEventTimeDifference As System.Windows.Forms.Label
    Friend WithEvents lblx As System.Windows.Forms.Label
    Friend WithEvents lblEventPctDifference As System.Windows.Forms.Label
    Friend WithEvents lbly As System.Windows.Forms.Label
    Friend WithEvents btnSaveEvent As System.Windows.Forms.Button
    Friend WithEvents OpenBeforeVideoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenAfterVideoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseBeforeVideoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAfterVideoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenEventListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveEventListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip10 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip11 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip12 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip13 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip14 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip15 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip16 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip17 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip18 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip19 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip20 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip21 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip22 As System.Windows.Forms.ToolTip
    Friend WithEvents btnBeforeMarkPixel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBeforeEventDuration As System.Windows.Forms.Label
    Friend WithEvents lblBeforeEventEnd As System.Windows.Forms.Label
    Friend WithEvents lblBeforeEventStart As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAfterEventDuration As System.Windows.Forms.Label
    Friend WithEvents lblAfterEventEnd As System.Windows.Forms.Label
    Friend WithEvents lblAfterEventStart As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClearValues As System.Windows.Forms.Button
    Friend WithEvents ToolTip23 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip24 As System.Windows.Forms.ToolTip
    Friend WithEvents lblBeforeVideoLength As System.Windows.Forms.Label
    Friend WithEvents lblAfterVideoLength As System.Windows.Forms.Label
    Friend WithEvents Event_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Event_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Before_Event_Start As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Before_Event_End As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Before_Duration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents After_Event_Start As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents After_Event_End As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents After_Duration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Time_Difference As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Percent_Difference As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
