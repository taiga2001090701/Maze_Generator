Public Class Main
    Dim lsn1, lsn2 As Integer 'Last Scroll
    Dim sl As Boolean 'Scroll Lock
    Dim m(,) As Byte
    Dim wx(,), wy(,) As Boolean
    Dim mx, my As Integer
    Dim cx, cy, sx, sy, gx, gy As Integer
    Dim cr, sr As Byte
    Dim ac As Bitmap
    Dim sc As Integer
    Dim bc1, bc2, bc3 As Boolean
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SNC()
        lsn1 = 1
        lsn2 = 2
        sl = False
    End Sub

    Private Sub S1_Scroll(sender As Object, e As EventArgs) Handles S1.Scroll
        If sl = False Then
            sl = True
            If lsn1 = 1 Then
                Select Case lsn2
                    Case 2
                        If 100 - S1.Value - S2.Value < 0 Then
                            S3.Value = 0
                            S2.Value = 100 - S1.Value
                        Else
                            S3.Value = 100 - S1.Value - S2.Value
                        End If
                    Case 3
                        If 100 - S1.Value - S3.Value < 0 Then
                            S2.Value = 0
                            S3.Value = 100 - S1.Value
                        Else
                            S2.Value = 100 - S1.Value - S3.Value
                        End If
                End Select
            Else
                Select Case lsn1
                    Case 2
                        If 100 - S1.Value - S2.Value < 0 Then
                            S3.Value = 0
                            S2.Value = 100 - S1.Value
                        Else
                            S3.Value = 100 - S1.Value - S2.Value
                        End If
                    Case 3
                        If 100 - S1.Value - S3.Value < 0 Then
                            S2.Value = 0
                            S3.Value = 100 - S1.Value
                        Else
                            S2.Value = 100 - S1.Value - S3.Value
                        End If
                End Select
                lsn2 = lsn1
                lsn1 = 1
            End If
            SNC()
            sl = False
        End If
    End Sub

    Private Sub S2_Scroll(sender As Object, e As EventArgs) Handles S2.Scroll
        If sl = False Then
            sl = True
            If lsn1 = 2 Then
                Select Case lsn2
                    Case 1
                        If 100 - S1.Value - S2.Value < 0 Then
                            S3.Value = 0
                            S1.Value = 100 - S2.Value
                        Else
                            S3.Value = 100 - S1.Value - S2.Value
                        End If
                    Case 3
                        If 100 - S2.Value - S3.Value < 0 Then
                            S1.Value = 0
                            S3.Value = 100 - S2.Value
                        Else
                            S1.Value = 100 - S2.Value - S3.Value
                        End If
                End Select
            Else
                Select Case lsn1
                    Case 1
                        If 100 - S1.Value - S2.Value < 0 Then
                            S3.Value = 0
                            S1.Value = 100 - S2.Value
                        Else
                            S3.Value = 100 - S1.Value - S2.Value
                        End If
                    Case 3
                        If 100 - S2.Value - S3.Value < 0 Then
                            S1.Value = 0
                            S3.Value = 100 - S2.Value
                        Else
                            S1.Value = 100 - S2.Value - S3.Value
                        End If
                End Select
                lsn2 = lsn1
                lsn1 = 2
            End If
            SNC()
            sl = False
        End If
    End Sub

    Private Sub S3_Scroll(sender As Object, e As EventArgs) Handles S3.Scroll
        If sl = False Then
            sl = True
            If lsn1 = 3 Then
                Select Case lsn2
                    Case 1
                        If 100 - S1.Value - S3.Value < 0 Then
                            S2.Value = 0
                            S1.Value = 100 - S3.Value
                        Else
                            S2.Value = 100 - S1.Value - S3.Value
                        End If
                    Case 2
                        If 100 - S2.Value - S3.Value < 0 Then
                            S1.Value = 0
                            S2.Value = 100 - S3.Value
                        Else
                            S1.Value = 100 - S2.Value - S3.Value
                        End If
                End Select
            Else
                Select Case lsn1
                    Case 1
                        If 100 - S1.Value - S3.Value < 0 Then
                            S2.Value = 0
                            S1.Value = 100 - S3.Value
                        Else
                            S2.Value = 100 - S1.Value - S3.Value
                        End If
                    Case 2
                        If 100 - S2.Value - S3.Value < 0 Then
                            S1.Value = 0
                            S2.Value = 100 - S3.Value
                        Else
                            S1.Value = 100 - S2.Value - S3.Value
                        End If
                End Select
                lsn2 = lsn1
                lsn1 = 3
            End If
            SNC()
            sl = False
        End If
    End Sub

    Sub SNC()
        LN1.Text = S1.Value & "%"
        LN2.Text = S2.Value & "%"
        LN3.Text = S3.Value & "%"
    End Sub

    Private Sub BG_Click(sender As Object, e As EventArgs) Handles BG.Click
        If IsNumeric(TBS.Text) = False Then
            TBS.Text = Environment.TickCount
        End If
        Dim seed As Integer
        Try
            seed = CInt(TBS.Text)
        Catch ex As Exception
            MsgBox("乱数種の絶対値が大きすぎます")
            Exit Sub
        End Try
        '操作無効化
        UDX.Enabled = False
        UDY.Enabled = False
        S1.Enabled = False
        S2.Enabled = False
        S3.Enabled = False
        TBS.Enabled = False
        BG.Enabled = False
        'キャンバス生成
        Dim r As New Random(TBS.Text)
        mx = UDX.Value
        my = UDY.Value
        Dim ms As Integer = mx * my
        Dim c As New Bitmap(mx * 9 + 1, my * 9 + 1)
        Dim g As Graphics = Graphics.FromImage(c)
        ReDim m(mx - 1, my - 1)
        ReDim wx(mx - 1, my), wy(mx, my - 1)
        Dim p1 As Integer = S1.Value
        Dim p2 As Integer = S2.Value
        Dim p3 As Integer = S3.Value
        Dim rc As Integer = 0
        PB.Image = c
        sc = 0
        '白塗り
        For ix = 0 To mx * 9
            For iy = 0 To my * 9
                c.SetPixel(ix, iy, Color.White)
            Next
            PB.Refresh()
            Application.DoEvents()
        Next
        '格子点・外枠
        g.DrawRectangle(Pens.Black, 0, 0, c.Width - 1, c.Height - 1)
        For ix = 9 To mx * 9 - 9 Step 9
            For iy = 9 To my * 9 - 9 Step 9
                c.SetPixel(ix, iy, Color.Black)
            Next
            PB.Refresh()
            Application.DoEvents()
        Next
        For i = 0 To mx - 1
            wx(i, 0) = 1
            wx(i, my) = 1
        Next
        For i = 0 To my - 1
            wy(0, i) = 1
            wy(mx, i) = 1
        Next
        'スタート地点
        Dim mi, ma As Integer
        If mx < my Then
            mi = 1
            ma = 3
        ElseIf mx > my Then
            mi = 3
            ma = 5
        Else
            mi = 1
            ma = 5
        End If
        Select Case r.Next(mi, ma)
            Case 1
                Dim rt As Integer = r.Next(0, mx)
                g.DrawLine(Pens.Green, rt * 9 + 1, 0, rt * 9 + 8, 0)
                m(rt, 0) = 1
                cx = rt + 1
                cy = 1
                sx = rt + 1
                sy = 1
                cr = 1
                sr = 1
            Case 2
                Dim rt As Integer = r.Next(0, mx)
                g.DrawLine(Pens.Green, rt * 9 + 1, my * 9, rt * 9 + 8, my * 9)
                m(rt, my - 1) = 1
                cx = rt + 1
                cy = my
                sx = rt + 1
                sy = my
                cr = 2
                sr = 2
            Case 3
                Dim rt As Integer = r.Next(0, my)
                g.DrawLine(Pens.Green, 0, rt * 9 + 1, 0, rt * 9 + 8)
                m(0, rt) = 1
                cx = 1
                cy = rt + 1
                sx = 1
                sy = rt + 1
                cr = 3
                sr = 3
            Case 4
                Dim rt As Integer = r.Next(0, my)
                g.DrawLine(Pens.Green, mx * 9, rt * 9 + 1, mx * 9, rt * 9 + 8)
                m(mx - 1, rt) = 1
                cx = mx
                cy = rt + 1
                sx = mx
                sy = rt + 1
                cr = 4
                sr = 4
        End Select
        rc += 1
        LRP.Text = "(" & cx & ", " & cy & ")"
        LRC.Text = rc & " / " & ms
        PB.Refresh()
        'ルート生成
        Dim bw As Boolean = 0
        Dim gg As Boolean = 0
        bc1 = 0
        bc2 = 0
        bc3 = 0
        Do
            If r.Next(0, 100) < p1 Then
                Select Case cr
                    Case 1
                        If bw AndAlso cy < my AndAlso m(cx - 1, cy) = 0 Then
                            bw = 0
                            g.DrawLine(Pens.White, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                            wx(cx - 1, cy) = 0
                            cy += 1
                            rc += 1
                            CN()
                        ElseIf wx(cx - 1, cy) = 0 Then
                            If cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                                g.DrawLine(Pens.Black, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                                wy(cx - 1, cy - 1) = 1
                            End If
                            If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                g.DrawLine(Pens.Black, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                                wy(cx, cy - 1) = 1
                            End If
                            cy += 1
                            If m(cx - 1, cy - 1) = 0 Then
                                rc += 1
                            End If
                            CN()
                        Else
                            bc1 = 1
                        End If
                    Case 2
                        If bw AndAlso cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                            bw = 0
                            g.DrawLine(Pens.White, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                            wx(cx - 1, cy - 1) = 0
                            cy -= 1
                            rc += 1
                            CN()
                        ElseIf wx(cx - 1, cy - 1) = 0 Then
                            If cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                                g.DrawLine(Pens.Black, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                                wy(cx - 1, cy - 1) = 1
                            End If
                            If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                g.DrawLine(Pens.Black, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                                wy(cx, cy - 1) = 1
                            End If
                            cy -= 1
                            If m(cx - 1, cy - 1) = 0 Then
                                rc += 1
                            End If
                            CN()
                        Else
                            bc1 = 1
                        End If
                    Case 3
                        If bw AndAlso cx < mx AndAlso m(cx, cy - 1) = 0 Then
                            bw = 0
                            g.DrawLine(Pens.White, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                            wy(cx, cy - 1) = 0
                            cx += 1
                            rc += 1
                            CN()
                        ElseIf wy(cx, cy - 1) = 0 Then
                            If cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                                g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                                wx(cx - 1, cy - 1) = 1
                            End If
                            If cy < my AndAlso m(cx - 1, cy) = 0 Then
                                g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                                wx(cx - 1, cy) = 1
                            End If
                            cx += 1
                            If m(cx - 1, cy - 1) = 0 Then
                                rc += 1
                            End If
                            CN()
                        Else
                            bc1 = 1
                        End If
                    Case 4
                        If bw AndAlso cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                            bw = 0
                            g.DrawLine(Pens.White, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                            wy(cx - 1, cy - 1) = 0
                            cx -= 1
                            rc += 1
                            CN()
                        ElseIf wy(cx - 1, cy - 1) = 0 Then
                            If cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                                g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                                wx(cx - 1, cy - 1) = 1
                            End If
                            If cy < my AndAlso m(cx - 1, cy) = 0 Then
                                g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                                wx(cx - 1, cy) = 1
                            End If
                            cx -= 1
                            If m(cx - 1, cy - 1) = 0 Then
                                rc += 1
                            End If
                            CN()
                        Else
                            bc1 = 1
                        End If
                End Select
            Else
                Select Case r.Next(0, 2)
                    Case 0
                        Select Case cr
                            Case 1
                                If bw AndAlso cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                                    bw = 0
                                    g.DrawLine(Pens.White, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                                    wy(cx - 1, cy - 1) = 0
                                    cx -= 1
                                    cr = 4
                                    rc += 1
                                    CN()
                                ElseIf wy(cx - 1, cy - 1) = 0 Then
                                    If cy < my AndAlso m(cx - 1, cy) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                                        wx(cx - 1, cy) = 1
                                    End If
                                    If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                        g.DrawLine(Pens.Black, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                                        wy(cx, cy - 1) = 1
                                    End If
                                    cx -= 1
                                    cr = 4
                                    If m(cx - 1, cy - 1) = 0 Then
                                        rc += 1
                                    End If
                                    CN()
                                Else
                                    bc2 = 1
                                End If
                            Case 2
                                If bw AndAlso cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                                    bw = 0
                                    g.DrawLine(Pens.White, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                                    wy(cx - 1, cy - 1) = 0
                                    cx -= 1
                                    cr = 4
                                    rc += 1
                                    CN()
                                ElseIf wy(cx - 1, cy - 1) = 0 Then
                                    If cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                                        wx(cx - 1, cy - 1) = 1
                                    End If
                                    If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                        g.DrawLine(Pens.Black, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                                        wy(cx, cy - 1) = 1
                                    End If
                                    cx -= 1
                                    cr = 4
                                    If m(cx - 1, cy - 1) = 0 Then
                                        rc += 1
                                    End If
                                    CN()
                                Else
                                    bc2 = 1
                                End If
                            Case 3
                                If bw AndAlso cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                                    bw = 0
                                    g.DrawLine(Pens.White, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                                    wx(cx - 1, cy - 1) = 0
                                    cy -= 1
                                    cr = 2
                                    rc += 1
                                    CN()
                                ElseIf wx(cx - 1, cy - 1) = 0 Then
                                    If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                        g.DrawLine(Pens.Black, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                                        wy(cx, cy - 1) = 1
                                    End If
                                    If cy < my AndAlso m(cx - 1, cy) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                                        wx(cx - 1, cy) = 1
                                    End If
                                    cy -= 1
                                    cr = 2
                                    If m(cx - 1, cy - 1) = 0 Then
                                        rc += 1
                                    End If
                                    CN()
                                Else
                                    bc2 = 1
                                End If
                            Case 4
                                If bw AndAlso cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                                    bw = 0
                                    g.DrawLine(Pens.White, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                                    wx(cx - 1, cy - 1) = 0
                                    cy -= 1
                                    cr = 2
                                    rc += 1
                                    CN()
                                ElseIf wx(cx - 1, cy - 1) = 0 Then
                                    If cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                                        wy(cx - 1, cy - 1) = 1
                                    End If
                                    If cy < my AndAlso m(cx - 1, cy) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                                        wx(cx - 1, cy) = 1
                                    End If
                                    cy -= 1
                                    cr = 2
                                    If m(cx - 1, cy - 1) = 0 Then
                                        rc += 1
                                    End If
                                    CN()
                                Else
                                    bc2 = 1
                                End If
                        End Select
                    Case 1
                        Select Case cr
                            Case 1
                                If bw AndAlso cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                    bw = 0
                                    g.DrawLine(Pens.White, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                                    wy(cx, cy - 1) = 0
                                    cx += 1
                                    cr = 3
                                    rc += 1
                                    CN()
                                ElseIf wy(cx, cy - 1) = 0 Then
                                    If cy < my AndAlso m(cx - 1, cy) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                                        wx(cx - 1, cy) = 1
                                    End If
                                    If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                                        wy(cx - 1, cy - 1) = 1
                                    End If
                                    cx += 1
                                    cr = 3
                                    If m(cx - 1, cy - 1) = 0 Then
                                        rc += 1
                                    End If
                                    CN()
                                Else
                                    bc3 = 1
                                End If
                            Case 2
                                If bw AndAlso cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                    bw = 0
                                    g.DrawLine(Pens.White, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                                    wy(cx, cy - 1) = 0
                                    cx += 1
                                    cr = 3
                                    rc += 1
                                    CN()
                                ElseIf wy(cx, cy - 1) = 0 Then
                                    If cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                                        wx(cx - 1, cy - 1) = 1
                                    End If
                                    If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                                        wy(cx - 1, cy - 1) = 1
                                    End If
                                    cx += 1
                                    cr = 3
                                    If m(cx - 1, cy - 1) = 0 Then
                                        rc += 1
                                    End If
                                    CN()
                                Else
                                    bc3 = 1
                                End If
                            Case 3
                                If bw AndAlso cy < my AndAlso m(cx - 1, cy) = 0 Then
                                    bw = 0
                                    g.DrawLine(Pens.White, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                                    wx(cx - 1, cy) = 0
                                    cy += 1
                                    cr = 1
                                    rc += 1
                                    CN()
                                ElseIf wx(cx - 1, cy) = 0 Then
                                    If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                                        g.DrawLine(Pens.Black, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                                        wy(cx, cy - 1) = 1
                                    End If
                                    If cy < my AndAlso m(cx - 1, cy) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                                        wx(cx - 1, cy - 1) = 1
                                    End If
                                    cy += 1
                                    cr = 1
                                    If m(cx - 1, cy - 1) = 0 Then
                                        rc += 1
                                    End If
                                    CN()
                                Else
                                    bc3 = 1
                                End If
                            Case 4
                                If bw AndAlso cy < my AndAlso m(cx - 1, cy) = 0 Then
                                    bw = 0
                                    g.DrawLine(Pens.White, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                                    wx(cx - 1, cy) = 0
                                    cy += 1
                                    cr = 1
                                    rc += 1
                                    CN()
                                ElseIf wx(cx - 1, cy) = 0 Then
                                    If cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                                        wy(cx - 1, cy - 1) = 1
                                    End If
                                    If cy < my AndAlso m(cx - 1, cy) = 0 Then
                                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                                        wx(cx - 1, cy - 1) = 1
                                    End If
                                    cy += 1
                                    cr = 1
                                    If m(cx - 1, cy - 1) = 0 Then
                                        rc += 1
                                    End If
                                    CN()
                                Else
                                    bc3 = 1
                                End If
                        End Select
                End Select
            End If
            If gg = 0 Then
                If cr = 1 AndAlso sr = 1 AndAlso cy = my Then
                    g.DrawLine(Pens.Red, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                    If cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                        g.DrawLine(Pens.Black, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                        wy(cx - 1, cy - 1) = 1
                    End If
                    If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                        g.DrawLine(Pens.Black, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                        wy(cx, cy - 1) = 1
                    End If
                    gg = 1
                    gx = cx
                    gy = cy
                    bc1 = 1
                    bc2 = 1
                    bc3 = 1
                ElseIf cr = 2 AndAlso sr = 2 AndAlso cy = 1 Then
                    g.DrawLine(Pens.Red, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                    If cx > 1 AndAlso m(cx - 2, cy - 1) = 0 Then
                        g.DrawLine(Pens.Black, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                        wy(cx - 1, cy - 1) = 1
                    End If
                    If cx < mx AndAlso m(cx, cy - 1) = 0 Then
                        g.DrawLine(Pens.Black, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                        wy(cx, cy - 1) = 1
                    End If
                    gg = 1
                    gx = cx
                    gy = cy
                    bc1 = 1
                    bc2 = 1
                    bc3 = 1
                ElseIf cr = 3 AndAlso sr = 3 AndAlso cx = mx Then
                    g.DrawLine(Pens.Red, cx * 9, (cy - 1) * 9 + 1, cx * 9, (cy - 1) * 9 + 8)
                    If cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                        wx(cx - 1, cy - 1) = 1
                    End If
                    If cy < my AndAlso m(cx - 1, cy) = 0 Then
                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                        wx(cx - 1, cy) = 1
                    End If
                    gg = 1
                    gx = cx
                    gy = cy
                    bc1 = 1
                    bc2 = 1
                    bc3 = 1
                ElseIf cr = 4 AndAlso sr = 4 AndAlso cx = 1 Then
                    g.DrawLine(Pens.Red, (cx - 1) * 9, (cy - 1) * 9 + 1, (cx - 1) * 9, (cy - 1) * 9 + 8)
                    If cy > 1 AndAlso m(cx - 1, cy - 2) = 0 Then
                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, (cy - 1) * 9, (cx - 1) * 9 + 8, (cy - 1) * 9)
                        wx(cx - 1, cy - 1) = 1
                    End If
                    If cy < my AndAlso m(cx - 1, cy) = 0 Then
                        g.DrawLine(Pens.Black, (cx - 1) * 9 + 1, cy * 9, (cx - 1) * 9 + 8, cy * 9)
                        wx(cx - 1, cy) = 1
                    End If
                    gg = 1
                    gx = cx
                    gy = cy
                    bc1 = 1
                    bc2 = 1
                    bc3 = 1
                End If
            End If
            If bc1 AndAlso bc2 AndAlso bc3 Then
                bc1 = 0
                bc2 = 0
                bc3 = 0
                bw = 1
                Do
                    Dim rt As Integer = r.Next(0, rc - sc)
                    Dim rct As Integer = 0
                    Dim rsb As Byte = 0
                    For ix = 0 To mx - 1
                        For iy = 0 To my - 1
                            If m(ix, iy) = 1 Then
                                If rct = rt Then
                                    If ix > 0 AndAlso m(ix - 1, iy) = 0 OrElse iy > 0 AndAlso m(ix, iy - 1) = 0 OrElse ix < mx - 1 AndAlso m(ix + 1, iy) = 0 OrElse iy < my - 1 AndAlso m(ix, iy + 1) = 0 Then
                                        If gg = 0 OrElse gg AndAlso New Point(ix, iy) <> New Point(gx - 1, gy - 1) Then
                                            cx = ix + 1
                                            cy = iy + 1
                                            cr = r.Next(1, 5)
                                            rsb = 2
                                            Exit For
                                        Else
                                            rsb = 1
                                            Exit For
                                        End If
                                    Else
                                        rsb = 1
                                        Exit For
                                    End If
                                Else
                                    rct += 1
                                End If
                            End If
                        Next
                        If rsb > 0 Then
                            Exit For
                        End If
                    Next
                    If rsb = 2 Then
                        Exit Do
                    End If
                    Application.DoEvents()
                Loop
            End If
            LRP.Text = "(" & cx & ", " & cy & ")"
            LRC.Text = rc & " / " & ms
            Application.DoEvents()
            If rc = ms Then
                For ix = 0 To mx - 1
                    For iy = 0 To my - 1
                        If m(ix, iy) = 2 Then
                            m(ix, iy) = 1
                        End If
                    Next
                    Application.DoEvents()
                Next
                Exit Do
            End If
        Loop
        '正解ルート検索
        Dim uc As Integer = 0
        ac = c.Clone()
        cx = sx
        cy = sy
        cr = sr
        PB.Image = ac
        PB.Refresh()
        Do
            If m(cx - 1, cy - 1) = 1 Then
                Select Case cr
                    Case 1
                        If cy > 1 AndAlso m(cx - 1, cy - 2) = 1 Then
                            For ix = (cx - 1) * 9 + 3 To (cx - 1) * 9 + 6
                                For iy = (cy - 2) * 9 + 3 To (cy - 2) * 9 + 6
                                    ac.SetPixel(ix, iy, Color.DarkBlue)
                                Next
                            Next
                            m(cx - 1, cy - 2) = 2
                            uc += 1
                        End If
                    Case 2
                        If cy < my AndAlso m(cx - 1, cy) = 1 Then
                            For ix = (cx - 1) * 9 + 3 To (cx - 1) * 9 + 6
                                For iy = cy * 9 + 3 To cy * 9 + 6
                                    ac.SetPixel(ix, iy, Color.DarkBlue)
                                Next
                            Next
                            m(cx - 1, cy) = 2
                            uc += 1
                        End If
                    Case 3
                        If cx > 1 AndAlso m(cx - 2, cy - 1) = 1 Then
                            For ix = (cx - 2) * 9 + 3 To (cx - 2) * 9 + 6
                                For iy = (cy - 1) * 9 + 3 To (cy - 1) * 9 + 6
                                    ac.SetPixel(ix, iy, Color.DarkBlue)
                                Next
                            Next
                            m(cx - 2, cy - 1) = 2
                            uc += 1
                        End If
                    Case 4
                        If cx < mx AndAlso m(cx, cy - 1) = 1 Then
                            For ix = cx * 9 + 3 To cx * 9 + 6
                                For iy = (cy - 1) * 9 + 3 To (cy - 1) * 9 + 6
                                    ac.SetPixel(ix, iy, Color.DarkBlue)
                                Next
                            Next
                            m(cx, cy - 1) = 2
                            uc += 1
                        End If
                End Select
                For ix = (cx - 1) * 9 + 3 To (cx - 1) * 9 + 6
                    For iy = (cy - 1) * 9 + 3 To (cy - 1) * 9 + 6
                        ac.SetPixel(ix, iy, Color.DarkBlue)
                    Next
                Next
                m(cx - 1, cy - 1) = 2
                uc += 1
            Else
                For ix = (cx - 1) * 9 + 3 To (cx - 1) * 9 + 6
                    For iy = (cy - 1) * 9 + 3 To (cy - 1) * 9 + 6
                        ac.SetPixel(ix, iy, Color.White)
                    Next
                Next
                m(cx - 1, cy - 1) = 1
                uc -= 1
            End If
            LRP.Text = "(" & cx & ", " & cy & ")"
            LRC.Text = uc & " / " & ms
            PB.Refresh()
            Application.DoEvents()
            If cx <> gx OrElse cy <> gy Then
                Select Case cr
                    Case 1
                        If wy(cx - 1, cy - 1) = 0 Then
                            cr = 4
                            cx -= 1
                        ElseIf wx(cx - 1, cy) = 0 Then
                            cy += 1
                        ElseIf wy(cx, cy - 1) = 0 Then
                            cr = 3
                            cx += 1
                        Else
                            For ix = (cx - 1) * 9 + 3 To (cx - 1) * 9 + 6
                                For iy = (cy - 1) * 9 + 3 To (cy - 1) * 9 + 6
                                    ac.SetPixel(ix, iy, Color.White)
                                Next
                            Next
                            cr = 2
                            m(cx - 1, cy - 1) = 1
                            cy -= 1
                            uc -= 1
                        End If
                    Case 2
                        If wy(cx, cy - 1) = 0 Then
                            cr = 3
                            cx += 1
                        ElseIf wx(cx - 1, cy - 1) = 0 Then
                            cy -= 1
                        ElseIf wy(cx - 1, cy - 1) = 0 Then
                            cr = 4
                            cx -= 1
                        Else
                            For ix = (cx - 1) * 9 + 3 To (cx - 1) * 9 + 6
                                For iy = (cy - 1) * 9 + 3 To (cy - 1) * 9 + 6
                                    ac.SetPixel(ix, iy, Color.White)
                                Next
                            Next
                            cr = 1
                            m(cx - 1, cy - 1) = 1
                            cy += 1
                            uc -= 1
                        End If
                    Case 3
                        If wx(cx - 1, cy) = 0 Then
                            cr = 1
                            cy += 1
                        ElseIf wy(cx, cy - 1) = 0 Then
                            cx += 1
                        ElseIf wx(cx - 1, cy - 1) = 0 Then
                            cr = 2
                            cy -= 1
                        Else
                            For ix = (cx - 1) * 9 + 3 To (cx - 1) * 9 + 6
                                For iy = (cy - 1) * 9 + 3 To (cy - 1) * 9 + 6
                                    ac.SetPixel(ix, iy, Color.White)
                                Next
                            Next
                            cr = 4
                            m(cx - 1, cy - 1) = 1
                            cx -= 1
                            uc -= 1
                        End If
                    Case 4
                        If wx(cx - 1, cy - 1) = 0 Then
                            cr = 2
                            cy -= 1
                        ElseIf wy(cx - 1, cy - 1) = 0 Then
                            cx -= 1
                        ElseIf wx(cx - 1, cy) = 0 Then
                            cr = 1
                            cy += 1
                        Else
                            For ix = (cx - 1) * 9 + 3 To (cx - 1) * 9 + 6
                                For iy = (cy - 1) * 9 + 3 To (cy - 1) * 9 + 6
                                    ac.SetPixel(ix, iy, Color.White)
                                Next
                            Next
                            cr = 3
                            m(cx - 1, cy - 1) = 1
                            cx += 1
                            uc -= 1
                        End If
                End Select
            Else
                Exit Do
            End If
        Loop
        '最終処理
        If IO.Directory.Exists("Maze") = False Then
            IO.Directory.CreateDirectory("Maze")
        End If
        Dim sfd As New SaveFileDialog()
        LRP.Text = "生成完了"
        sfd.FileName = mx & "-" & my & "_" & p1 & "_" & seed & "_" & uc & "-" & ms & ".png"
        sfd.InitialDirectory = "¥Maze"
        sfd.Filter = "PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*"
        sfd.Title = "保存先のファイルを選択してください"
        sfd.RestoreDirectory = True
        If sfd.ShowDialog() = DialogResult.OK Then
            c.Save(sfd.FileName, Imaging.ImageFormat.Png)
            ac.Save(sfd.FileName.Substring(0, sfd.FileName.Length - 4) & "_A" & ".png", Imaging.ImageFormat.Png)
        End If
        UDX.Enabled = True
        UDY.Enabled = True
        S1.Enabled = True
        S2.Enabled = True
        S3.Enabled = True
        TBS.Enabled = True
        BG.Enabled = True
    End Sub

    Sub CN()
        If m(cx - 1, cy - 1) = 0 Then
            If cx = 1 OrElse m(cx - 2, cy - 1) > 0 Then
                If cx = mx OrElse m(cx, cy - 1) > 0 Then
                    If cy = 1 OrElse m(cx - 1, cy - 2) > 0 Then
                        If cy = my OrElse m(cx - 1, cy) > 0 Then
                            m(cx - 1, cy - 1) = 2
                            sc += 1
                        Else
                            m(cx - 1, cy - 1) = 1
                        End If
                    Else
                        m(cx - 1, cy - 1) = 1
                    End If
                Else
                    m(cx - 1, cy - 1) = 1
                End If
            Else
                m(cx - 1, cy - 1) = 1
            End If
        End If
        bc1 = 0
        bc2 = 0
        bc3 = 0
        PB.Refresh()
    End Sub
End Class