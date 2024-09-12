Public Class frmMain
    Dim bGetXYClick As Boolean
    Dim xyPos As System.Drawing.Point
    Dim iRed, iBlue, iGreen As Integer
    Dim iX_Pos, iY_Pos As Integer
    Dim iNextRowID As Integer


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vidBefore.uiMode = "None"
        vidAfter.uiMode = "None"

        vidBefore.settings.autoStart = False
        vidAfter.settings.autoStart = False
        vidBefore.settings.mute = True
        vidAfter.settings.mute = True
        bGetXYClick = False

        iNextRowID = 1

        ToolTip1.SetToolTip(btnBeforeMoveFirst, "Move to Start")
        ToolTip2.SetToolTip(btnBeforeStepPrev, "Step Backward")
        ToolTip3.SetToolTip(btnBeforePause, "Pause")
        ToolTip4.SetToolTip(btnBeforeStepNext, "Step Forward")
        ToolTip5.SetToolTip(btnBeforeMoveLast, "Move to End")
        ToolTip6.SetToolTip(btnBeforePlay, "Play")
        ToolTip7.SetToolTip(btnBeforeRefresh, "Refresh Screen")
        ToolTip8.SetToolTip(btnBeforePlay2Pixel, "Play Until Pixel Change")
        ToolTip9.SetToolTip(btnBeforeMarkPixel, "Set Pixel to Watch")
        ToolTip10.SetToolTip(btnBeforeEventStart, "Record Event Start Time")
        ToolTip11.SetToolTip(btnBeforeEventEnd, "Record Event End Time")

        ToolTip12.SetToolTip(btnAfterMoveFirst, "Move to Start")
        ToolTip13.SetToolTip(btnAfterStepPrev, "Step Backward")
        ToolTip14.SetToolTip(btnAfterPause, "Pause")
        ToolTip15.SetToolTip(btnAfterStepNext, "Step Forward")
        ToolTip16.SetToolTip(btnAfterMoveLast, "Move to End")
        ToolTip17.SetToolTip(btnAfterPlay, "Play")
        ToolTip18.SetToolTip(btnAfterRefresh, "Refresh Screen")
        ToolTip19.SetToolTip(btnAfterPlay2Pixel, "Play Until Pixel Change")
        ToolTip20.SetToolTip(btnAfterMarkPixel, "Set Pixel to Watch")
        ToolTip21.SetToolTip(btnAfterEventStart, "Record Event Start Time")
        ToolTip22.SetToolTip(btnAfterEventEnd, "Record Event End Time")

        ToolTip23.SetToolTip(btnClearValues, "Clear Event Values")
        ToolTip24.SetToolTip(btnSaveEvent, "Save Event To Table Below")

        DisableAfterButtons()
        DisableBeforeButtons()
        SaveEventListToolStripMenuItem.Enabled = False

    End Sub

#Region "Menu"

    Private Sub OpenBeforeVideoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBeforeVideoToolStripMenuItem1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "Video files (*.avi)|*.avi|Video files (*.wmv)|*.wmv|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                vidBefore.URL = openFileDialog1.FileName
                TabControl1.TabPages(0).Text = "Before File: " & vidBefore.currentMedia.name
                TabControl1.SelectTab(0)

                EnableBeforeButtons()
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub OpenAfterVideoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAfterVideoToolStripMenuItem1.Click
        Dim openFileDialog2 As New OpenFileDialog()

        openFileDialog2.Filter = "Video files (*.avi)|*.avi|Video files (*.wmv)|*.wmv|All files (*.*)|*.*"
        openFileDialog2.FilterIndex = 1
        openFileDialog2.RestoreDirectory = True
        openFileDialog2.Multiselect = False

        If openFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                vidAfter.URL = openFileDialog2.FileName
                TabControl1.TabPages(1).Text = "After File: " & vidAfter.currentMedia.name
                TabControl1.SelectTab(1)

                EnableAfterButtons()
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub CloseBeforeVideoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBeforeVideoToolStripMenuItem1.Click
        vidBefore.URL = ""
        TabControl1.TabPages(0).Text = "Before File: "
        TabControl1.SelectTab(0)

        DisableBeforeButtons()

    End Sub

    Private Sub CloseAfterVideoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAfterVideoToolStripMenuItem1.Click
        vidAfter.URL = ""
        TabControl1.TabPages(1).Text = "After File: "
        TabControl1.SelectTab(1)

        DisableAfterButtons()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub SaveEventListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveEventListToolStripMenuItem.Click
        Dim saveFileDialog2 As New SaveFileDialog()

        If dgEventList.Rows.Count > 1 Then

            saveFileDialog2.Filter = "Comma-Separated Value File (*.csv)|*.csv"
            saveFileDialog2.FilterIndex = 1
            saveFileDialog2.RestoreDirectory = True

            If saveFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    Using writer As StreamWriter = New StreamWriter(saveFileDialog2.FileName.ToString)
                        writer.WriteLine("Event ID" & Chr(9) & "Event Name" & Chr(9) & "Before Event Start" & Chr(9) & "Before Event End" & Chr(9) & "Before Duration" & Chr(9) & "After Event Start" & Chr(9) & "After Event End" & Chr(9) & "After Duration" & Chr(9) & "Time Difference" & Chr(9) & "Percent Difference")
                        For i = 0 To dgEventList.Rows.Count - 2
                            writer.Write(dgEventList.Rows(i).Cells("Event_ID").Value & ",")
                            writer.Write(dgEventList.Rows(i).Cells("Event_Name").Value & ",")
                            writer.Write(dgEventList.Rows(i).Cells("Before_Event_Start").Value & ",")
                            writer.Write(dgEventList.Rows(i).Cells("Before_Event_End").Value & ",")
                            writer.Write(dgEventList.Rows(i).Cells("Before_Duration").Value & ",")
                            writer.Write(dgEventList.Rows(i).Cells("After_Event_Start").Value & ",")
                            writer.Write(dgEventList.Rows(i).Cells("After_Event_End").Value & ",")
                            writer.Write(dgEventList.Rows(i).Cells("After_Duration").Value & ",")
                            writer.Write(dgEventList.Rows(i).Cells("Time_Difference").Value & ",")
                            writer.WriteLine(dgEventList.Rows(i).Cells("Percent_Difference").Value)
                        Next
                    End Using

                Catch Ex As Exception
                    MessageBox.Show("File Error. Original error: " & Ex.Message)
                End Try
            End If
        Else
            MsgBox("Please add rows before saving the list.")
        End If
    End Sub

    Private Sub OpenEventListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenEventListToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim strHeader As String
        Dim strRow() As String = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
        Dim iRow As Integer

        openFileDialog1.Filter = "Comma-Separated Value File (*.csv)|*.csv"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                For i = dgEventList.Rows.Count - 2 To 0 Step -1
                    dgEventList.Rows.RemoveAt(i)
                Next
                iRow = 0
                Using reader As StreamReader = New StreamReader(openFileDialog1.FileName.ToString)
                    strHeader = reader.ReadLine
                    Do Until reader.EndOfStream
                        strRow(iRow) = reader.ReadLine
                        iRow += 1
                    Loop
                End Using

                Dim j As Integer
                For i = 0 To iRow - 1
                    If strRow(i) <> "" Then
                        dgEventList.Rows.Add()
                        j = 0
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("Event_ID").Value = dgEventList.Rows(i).Cells("Event_ID").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("Event_Name").Value = dgEventList.Rows(i).Cells("Event_Name").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("Before_Event_Start").Value = dgEventList.Rows(i).Cells("Before_Event_Start").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("Before_Event_End").Value = dgEventList.Rows(i).Cells("Before_Event_End").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("Before_Duration").Value = dgEventList.Rows(i).Cells("Before_Duration").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("After_Event_Start").Value = dgEventList.Rows(i).Cells("After_Event_Start").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("After_Event_End").Value = dgEventList.Rows(i).Cells("After_Event_End").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("After_Duration").Value = dgEventList.Rows(i).Cells("After_Duration").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> ","
                            dgEventList.Rows(i).Cells("Time_Difference").Value = dgEventList.Rows(i).Cells("Time_Difference").Value & strRow(i)(j)
                            j += 1
                        End While

                        j += 1
                        While strRow(i)(j) <> "%" And strRow(i)(j) <> "y"  'Infinity
                            dgEventList.Rows(i).Cells("Percent_Difference").Value = dgEventList.Rows(i).Cells("Percent_Difference").Value & strRow(i)(j)
                            j += 1
                        End While
                        dgEventList.Rows(i).Cells("Percent_Difference").Value = dgEventList.Rows(i).Cells("Percent_Difference").Value & strRow(i)(j)
                    End If
                Next
                SaveEventListToolStripMenuItem.Enabled = True
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

#End Region

#Region "Begin Buttons"

    Sub EnableBeforeButtons()
        btnBeforeMarkPixel.Enabled = True
        btnBeforeMoveFirst.Enabled = True
        btnBeforeMoveLast.Enabled = True
        btnBeforePause.Enabled = True
        btnBeforePlay.Enabled = True
        btnBeforeEventEnd.Enabled = True
        btnBeforeEventStart.Enabled = True
        btnBeforeRefresh.Enabled = True
        btnBeforeStepNext.Enabled = True
        btnBeforeStepPrev.Enabled = True
        txtBeforeInterval.Enabled = True
        txtBeforeVidTimer.Enabled = True
        txtBeforeVidTimer.Text = "000.0"
    End Sub

    Sub DisableBeforeButtons()
        btnBeforeMarkPixel.Enabled = False
        btnBeforeMoveFirst.Enabled = False
        btnBeforeMoveLast.Enabled = False
        btnBeforePause.Enabled = False
        btnBeforePlay.Enabled = False
        btnBeforeEventEnd.Enabled = False
        btnBeforeEventStart.Enabled = False
        btnBeforeRefresh.Enabled = False
        btnBeforeStepNext.Enabled = False
        btnBeforeStepPrev.Enabled = False
        txtBeforeInterval.Enabled = False
        txtBeforeVidTimer.Enabled = False
    End Sub

    Private Sub btnBeforePlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforePlay.Click
        vidBefore.Ctlcontrols.play()
        LoadBeforeCounter()
    End Sub


    Private Sub btnBeforePause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforePause.Click
        vidBefore.Ctlcontrols.pause()
        LoadBeforeCounter()

    End Sub

    Private Sub btnBeforeMoveLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforeMoveLast.Click

        vidBefore.Ctlcontrols.pause()
        vidBefore.Ctlcontrols.currentPosition = vidBefore.currentMedia.duration
        LoadBeforeCounter()

    End Sub

    Private Sub btnBeforeStepNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforeStepNext.Click
        vidBefore.Ctlcontrols.pause()
        vidBefore.Ctlcontrols.currentPosition = vidBefore.Ctlcontrols.currentPosition + (CDbl(txtBeforeInterval.Text) - 0.0075)
        vidBefore.Ctlcontrols.play()
        vidBefore.Ctlcontrols.pause()
        LoadBeforeCounter()

    End Sub

    Private Sub btnBeforeStepPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforeStepPrev.Click
        vidBefore.Ctlcontrols.pause()
        vidBefore.Ctlcontrols.currentPosition = vidBefore.Ctlcontrols.currentPosition - (CDbl(txtBeforeInterval.Text) + 0.0075)
        vidBefore.Ctlcontrols.play()
        vidBefore.Ctlcontrols.pause()
        LoadBeforeCounter()

    End Sub

    Private Sub btnBeforeMoveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforeMoveFirst.Click
        vidBefore.Ctlcontrols.pause()
        vidBefore.Ctlcontrols.currentPosition = 0
        vidBefore.Ctlcontrols.play()
        vidBefore.Ctlcontrols.pause()
        txtBeforeVidTimer.Text = "000.0"
    End Sub

    Private Sub btnBeforeRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforeRefresh.Click
        Dim TimerVal As String

        vidBefore.Ctlcontrols.play()
        vidBefore.Ctlcontrols.pause()
        Try
            TimerVal = txtBeforeVidTimer.Text.Replace(" ", "")
            vidBefore.Ctlcontrols.currentPosition = CDbl(TimerVal)
        Catch ex As Exception
            vidBefore.Ctlcontrols.currentPosition = 0.0
        End Try
        vidBefore.Ctlcontrols.play()
        vidBefore.Ctlcontrols.pause()
    End Sub

    Private Sub btnBeforeMarkPixel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforeMarkPixel.Click
        bGetXYClick = True
        TabControl1.Cursor = Cursors.Cross
        btnBeforePlay2Pixel.Enabled = True

    End Sub

    Private Sub btnBeforePlay2Pixel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforePlay2Pixel.Click
        Dim cResult As Color

        cResult = GetScreenPixel(xyPos)

        While (1)
            vidBefore.Ctlcontrols.step(1)
            cResult = GetScreenPixel(xyPos)

            If CInt(cResult.R) <> iRed Or CInt(cResult.B) <> iBlue Or CInt(cResult.G) <> iGreen Then
                LoadBeforeCounter()
                Exit While
            End If
        End While

        btnBeforePlay2Pixel.Enabled = False

    End Sub

    Private Sub btnBeforeEventStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforeEventStart.Click
        vidBefore.Ctlcontrols.pause()
        LoadBeforeCounter()
        lblBeforeEventStart.Text = txtBeforeVidTimer.Text

        If lblBeforeEventStart.Text <> "000.0" And lblBeforeEventEnd.Text <> "000.0" Then
            lblBeforeEventDuration.Text = FormatNumber(CDbl(lblBeforeEventEnd.Text) - CDbl(lblBeforeEventStart.Text), 1)
        End If

        If lblBeforeEventDuration.Text <> "000.0" And lblAfterEventDuration.Text <> "000.0" Then
            lblEventTimeDifference.Text = FormatNumber(CDbl(lblAfterEventDuration.Text) - CDbl(lblBeforeEventDuration.Text), 1)
            If CDbl(lblEventTimeDifference.Text) <> 0 Then
                lblEventPctDifference.Text = FormatPercent(CDbl(lblEventTimeDifference.Text) / CDbl(lblBeforeEventDuration.Text), 1)
            Else
                lblEventPctDifference.Text = "0.0%"
            End If
        End If

    End Sub

    Private Sub btnBeforeEventEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeforeEventEnd.Click
        vidBefore.Ctlcontrols.pause()
        LoadBeforeCounter()
        lblBeforeEventEnd.Text = txtBeforeVidTimer.Text

        If lblBeforeEventStart.Text <> "000.0" And lblBeforeEventEnd.Text <> "000.0" Then
            lblBeforeEventDuration.Text = FormatNumber(CDbl(lblBeforeEventEnd.Text) - CDbl(lblBeforeEventStart.Text), 1)
        End If

        If lblBeforeEventDuration.Text <> "000.0" And lblAfterEventDuration.Text <> "000.0" Then
            lblEventTimeDifference.Text = FormatNumber(CDbl(lblAfterEventDuration.Text) - CDbl(lblBeforeEventDuration.Text), 1)
            If CDbl(lblEventTimeDifference.Text) <> 0 Then
                lblEventPctDifference.Text = FormatPercent(CDbl(lblEventTimeDifference.Text) / CDbl(lblBeforeEventDuration.Text), 1)
            Else
                lblEventPctDifference.Text = "0.0%"
            End If
        End If
    End Sub

    Private Sub vidBefore_ClickEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles vidBefore.ClickEvent
        If bGetXYClick Then
            bGetXYClick = False

            Dim cResult As Color
            xyPos = Cursor.Position
            cResult = GetScreenPixel(xyPos)

            iRed = CInt(cResult.R)
            iBlue = CInt(cResult.B)
            iGreen = CInt(cResult.G)
            TabControl1.Cursor = Cursors.Default
        End If
    End Sub

    Sub LoadBeforeCounter()
        Dim dCurrentPosition As Double

        dCurrentPosition = vidBefore.Ctlcontrols.currentPosition / 10
        If dCurrentPosition < 1.0 Then
            txtBeforeVidTimer.Text = "00" & FormatNumber(dCurrentPosition, 2, TriState.False)
        ElseIf dCurrentPosition < 10.0 Then
            txtBeforeVidTimer.Text = "0" & FormatNumber(dCurrentPosition, 2, TriState.False)
        Else
            txtBeforeVidTimer.Text = FormatNumber(dCurrentPosition, 2, TriState.False)
        End If

    End Sub

#End Region

#Region "After Buttons"

    Sub DisableAfterButtons()
        btnAfterMarkPixel.Enabled = False
        btnAfterMoveFirst.Enabled = False
        btnAfterMoveLast.Enabled = False
        btnAfterPause.Enabled = False
        btnAfterPlay.Enabled = False
        btnAfterEventEnd.Enabled = False
        btnAfterEventStart.Enabled = False
        btnAfterRefresh.Enabled = False
        btnAfterStepNext.Enabled = False
        btnAfterStepPrev.Enabled = False
        txtAfterInterval.Enabled = False
        txtAfterVidTimer.Enabled = False
    End Sub

    Sub EnableAfterButtons()
        btnAfterMarkPixel.Enabled = True
        btnAfterMoveFirst.Enabled = True
        btnAfterMoveLast.Enabled = True
        btnAfterPause.Enabled = True
        btnAfterPlay.Enabled = True
        btnAfterEventEnd.Enabled = True
        btnAfterEventStart.Enabled = True
        btnAfterRefresh.Enabled = True
        btnAfterStepNext.Enabled = True
        btnAfterStepPrev.Enabled = True
        txtAfterInterval.Enabled = True
        txtAfterVidTimer.Enabled = True
        txtAfterVidTimer.Text = "000.0"
    End Sub

    Private Sub btnAfterPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterPlay.Click
        vidAfter.Ctlcontrols.play()
        LoadAfterCounter()
    End Sub


    Private Sub btnAfterPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterPause.Click
        vidAfter.Ctlcontrols.pause()
        LoadAfterCounter()

    End Sub

    Private Sub btnAfterMoveLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterMoveLast.Click

        vidAfter.Ctlcontrols.pause()
        vidAfter.Ctlcontrols.currentPosition = vidAfter.currentMedia.duration
        LoadAfterCounter()

    End Sub

    Private Sub btnAfterStepNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterStepNext.Click
        vidAfter.Ctlcontrols.pause()
        vidAfter.Ctlcontrols.currentPosition = vidAfter.Ctlcontrols.currentPosition + (CDbl(txtAfterInterval.Text) - 0.0075)
        vidAfter.Ctlcontrols.play()
        vidAfter.Ctlcontrols.pause()
        LoadAfterCounter()

    End Sub

    Private Sub btnAfterStepPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterStepPrev.Click
        vidAfter.Ctlcontrols.pause()
        vidAfter.Ctlcontrols.currentPosition = vidAfter.Ctlcontrols.currentPosition - (CDbl(txtAfterInterval.Text) + 0.0075)
        vidAfter.Ctlcontrols.play()
        vidAfter.Ctlcontrols.pause()
        LoadAfterCounter()

    End Sub

    Private Sub btnAfterMoveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterMoveFirst.Click
        vidAfter.Ctlcontrols.pause()
        vidAfter.Ctlcontrols.currentPosition = 0
        vidAfter.Ctlcontrols.play()
        vidAfter.Ctlcontrols.pause()
        txtAfterVidTimer.Text = "000.0"
    End Sub

    Private Sub btnAfterRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterRefresh.Click
        Dim TimerVal As String


        vidAfter.Ctlcontrols.play()
        vidAfter.Ctlcontrols.pause()
        Try
            TimerVal = txtAfterVidTimer.Text.Replace(" ", "")
            vidAfter.Ctlcontrols.currentPosition = CDbl(TimerVal)
        Catch ex As Exception
            vidAfter.Ctlcontrols.currentPosition = 0.0
        End Try
        vidAfter.Ctlcontrols.play()
        vidAfter.Ctlcontrols.pause()
    End Sub

    Private Sub btnAfterMarkPixel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterMarkPixel.Click
        bGetXYClick = True
        TabControl1.Cursor = Cursors.Cross

        btnAfterPlay2Pixel.Enabled = True

    End Sub

    Private Sub btnAfterPlay2Pixel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterPlay2Pixel.Click
        Dim cResult As Color

        cResult = GetScreenPixel(xyPos)

        While (1)
            vidAfter.Ctlcontrols.step(1)
            cResult = GetScreenPixel(xyPos)

            If CInt(cResult.R) <> iRed Or CInt(cResult.B) <> iBlue Or CInt(cResult.G) <> iGreen Then
                LoadAfterCounter()
                Exit While
            End If
        End While

        btnAfterPlay2Pixel.Enabled = False

    End Sub

    Private Sub btnAfterEventStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterEventStart.Click
        vidAfter.Ctlcontrols.pause()
        LoadAfterCounter()
        lblAfterEventStart.Text = txtAfterVidTimer.Text

        If lblAfterEventStart.Text <> "000.0" And lblAfterEventEnd.Text <> "000.0" Then
            lblAfterEventDuration.Text = FormatNumber(CDbl(lblAfterEventEnd.Text) - CDbl(lblAfterEventStart.Text), 1)
        End If

        If lblBeforeEventDuration.Text <> "000.0" And lblAfterEventDuration.Text <> "000.0" Then
            lblEventTimeDifference.Text = FormatNumber(CDbl(lblAfterEventDuration.Text) - CDbl(lblBeforeEventDuration.Text), 1)
            If CDbl(lblEventTimeDifference.Text) <> 0 Then
                lblEventPctDifference.Text = FormatPercent(CDbl(lblEventTimeDifference.Text) / CDbl(lblBeforeEventDuration.Text), 1)
            Else
                lblEventPctDifference.Text = "0.0%"
            End If
        End If

    End Sub

    Private Sub btnAfterEventEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfterEventEnd.Click
        vidAfter.Ctlcontrols.pause()
        LoadAfterCounter()
        lblAfterEventEnd.Text = txtAfterVidTimer.Text

        If lblAfterEventStart.Text <> "000.0" And lblAfterEventEnd.Text <> "000.0" Then
            lblAfterEventDuration.Text = FormatNumber(CDbl(lblAfterEventEnd.Text) - CDbl(lblAfterEventStart.Text), 1)
        End If

        If lblBeforeEventDuration.Text <> "000.0" And lblAfterEventDuration.Text <> "000.0" Then
            lblEventTimeDifference.Text = FormatNumber(CDbl(lblAfterEventDuration.Text) - CDbl(lblBeforeEventDuration.Text), 1)
            If CDbl(lblEventTimeDifference.Text) <> 0 Then
                lblEventPctDifference.Text = FormatPercent(CDbl(lblEventTimeDifference.Text) / CDbl(lblBeforeEventDuration.Text), 1)
            Else
                lblEventPctDifference.Text = "0.0%"
            End If
        End If
    End Sub

    Private Sub vidAfter_ClickEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles vidAfter.ClickEvent
        If bGetXYClick Then
            bGetXYClick = False

            Dim cResult As Color
            xyPos = Cursor.Position
            cResult = GetScreenPixel(xyPos)

            iRed = CInt(cResult.R)
            iBlue = CInt(cResult.B)
            iGreen = CInt(cResult.G)
            TabControl1.Cursor = Cursors.Default
        End If
    End Sub

    Sub LoadAfterCounter()
        Dim dCurrentPosition As Double

        dCurrentPosition = vidAfter.Ctlcontrols.currentPosition / 10
        If dCurrentPosition < 1.0 Then
            txtAfterVidTimer.Text = "00" & FormatNumber(dCurrentPosition, 2, TriState.False)
        ElseIf dCurrentPosition < 10.0 Then
            txtAfterVidTimer.Text = "0" & FormatNumber(dCurrentPosition, 2, TriState.False)
        Else
            txtAfterVidTimer.Text = FormatNumber(dCurrentPosition, 2, TriState.False)
        End If

    End Sub
#End Region


    Function GetScreenPixel(ByVal pt As Point) As Color
        Using bmp As New Bitmap(1, 1)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.CopyFromScreen(pt, Point.Empty, New Size(1, 1))
                Return bmp.GetPixel(0, 0)
            End Using
        End Using
    End Function


    Private Sub btnSaveEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEvent.Click
        Dim iRow As Integer

        SaveEventListToolStripMenuItem.Enabled = True

        If lblEventTimeDifference.Text <> "-000.0" Then
            If txtEventDescription.Text <> "" Then
                'Enter Data in GridView
                iRow = dgEventList.Rows.Count
                dgEventList.Rows.Add()
                dgEventList.Rows(iRow - 1).Cells("Event_ID").Value = iNextRowID.ToString
                dgEventList.Rows(iRow - 1).Cells("Event_Name").Value = txtEventDescription.Text
                dgEventList.Rows(iRow - 1).Cells("Before_Event_Start").Value = lblBeforeEventStart.Text
                dgEventList.Rows(iRow - 1).Cells("Before_Event_End").Value = lblBeforeEventEnd.Text
                dgEventList.Rows(iRow - 1).Cells("Before_Duration").Value = lblBeforeEventDuration.Text
                dgEventList.Rows(iRow - 1).Cells("After_Event_Start").Value = lblAfterEventStart.Text
                dgEventList.Rows(iRow - 1).Cells("After_Event_End").Value = lblAfterEventEnd.Text
                dgEventList.Rows(iRow - 1).Cells("After_Duration").Value = lblAfterEventDuration.Text
                dgEventList.Rows(iRow - 1).Cells("Time_Difference").Value = lblEventTimeDifference.Text
                dgEventList.Rows(iRow - 1).Cells("Percent_Difference").Value = lblEventPctDifference.Text
                iNextRowID += 1
                ClearValues()
            Else
                MsgBox("Event Description must be entered before the record can be saved.")
            End If
        Else
            MsgBox("'Before' and 'After' Event Start/End times must be captured before the record can be saved.")
        End If
    End Sub

    Sub ClearValues()
        txtEventDescription.Text = ""
        lblBeforeEventStart.Text = "000.0"
        lblBeforeEventEnd.Text = "000.0"
        lblBeforeEventDuration.Text = "000.0"
        lblAfterEventStart.Text = "000.0"
        lblAfterEventEnd.Text = "000.0"
        lblAfterEventDuration.Text = "000.0"
        lblEventTimeDifference.Text = "-000.0"
        lblEventPctDifference.Text = "000.0%"
    End Sub

    Private Sub btnClearValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearValues.Click
        ClearValues()
    End Sub

    Private Sub vidBefore_OpenStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_OpenStateChangeEvent) Handles vidBefore.OpenStateChange
        If vidBefore.openState = WMPOpenState.wmposMediaOpen Then
            lblBeforeVideoLength.Text = "of " & FormatNumber(vidBefore.currentMedia.duration, 2)
        End If
    End Sub


    Private Sub vidAfter_OpenStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_OpenStateChangeEvent) Handles vidAfter.OpenStateChange
        If vidAfter.openState = WMPOpenState.wmposMediaOpen Then
            lblAfterVideoLength.Text = "of " & FormatNumber(vidAfter.currentMedia.duration, 2)
        End If
    End Sub
End Class
