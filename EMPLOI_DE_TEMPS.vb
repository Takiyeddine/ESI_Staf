Imports System.Data.OleDb
Public Class EMPLOI_DE_TEMPS
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private cmd As OleDbCommand
    Private adapter As New OleDbDataAdapter
    Private dt As New DataTable()
    Private dtmdls As New DataTable()
    Private dts As New DataTable
    Dim con2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_tesgt.accdb")
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        con.Open()
        con.Close()
        con.Open()
        '***************************************************************
        '********Chargement de l'emploi de temps dans la base de données
        '***************************************************************
        '***************************************************************
        '******************************************************Colonne 1
        '********************************************************Ligne 1
        If ComboBox1.Text <> "" And ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox1.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If

        '***************************************************************
        If ComboBox2.Text <> "" And ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox2.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox3.Text <> "" And ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox3.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox4.Text <> "" And ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox4.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox5.Text <> "" And ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox5.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        '********************************************************Ligne 2
        If ComboBox6.Text <> "" And ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox6.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox7.Text <> "" And ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox7.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox8.Text <> "" And ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox8.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox9.Text <> "" And ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox9.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox10.Text <> "" And ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox10.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        '********************************************************Ligne 3
        If ComboBox11.Text <> "" And ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox11.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox12.Text <> "" And ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox12.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox13.Text <> "" And ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox13.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox14.Text <> "" And ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox14.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox15.Text <> "" And ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox15.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        '********************************************************Ligne 4
        If ComboBox18.Text <> "" And ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox18.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox21.Text <> "" And ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox21.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox23.Text <> "" And ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox23.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox20.Text <> "" And ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox20.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        If ComboBox16.Text <> "" And ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO EMPLOI_DE_TEMPS ([promo], [module], [ID_TIME]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = INITIALISATION.ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox16.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.ExecuteNonQuery()
        End If
        '***************************************************************
        con.Close()
        Form1.BunifuFlatButton1.Enabled = True
        Form1.BunifuFlatButton2.Enabled = True
        Form1.BunifuFlatButton3.Enabled = True
        Form1.BunifuFlatButton4.Enabled = True
        Form1.Hide()
        Me.Hide()
        SALLES_MODULES.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        con.Open()
        If ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO PERIODE ([ID_PERIODE], [H_D], [H_F]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox27.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox29.Text
            cmd.ExecuteNonQuery()
        End If

        AFFECTATION.BunifuThinButton22.ButtonText = ComboBox27.Text & "_" & ComboBox29.Text
        If ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO PERIODE ([ID_PERIODE], [H_D], [H_F]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox22.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox24.Text
            cmd.ExecuteNonQuery()
        End If

        AFFECTATION.BunifuThinButton23.ButtonText = ComboBox22.Text & "_" & ComboBox24.Text
        If ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO PERIODE ([ID_PERIODE], [H_D], [H_F]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox17.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox19.Text
            cmd.ExecuteNonQuery()
        End If

        AFFECTATION.BunifuThinButton24.ButtonText = ComboBox25.Text & "_" & ComboBox26.Text
        If ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO PERIODE ([ID_PERIODE], [H_D], [H_F]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = ComboBox25.Text
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox26.Text
            cmd.ExecuteNonQuery()
        End If

        AFFECTATION.BunifuThinButton230.ButtonText = ComboBox25.Text & "_" & ComboBox26.Text
        con.Close()
        ComboBox29.Enabled = False
        ComboBox27.Enabled = False
        ComboBox24.Enabled = False
        ComboBox22.Enabled = False
        ComboBox25.Enabled = False
        ComboBox26.Enabled = False
        ComboBox17.Enabled = False
        ComboBox19.Enabled = False
        MsgBox("Les périodes on été initialisé")
        con.Open()
        '******************************************************
        '***********************Initialisation de la table time
        '***********************************************Ligne 1
        If ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox27.Text <> "" And ComboBox29.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text & Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox27.Text & "_" & ComboBox29.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        '***********************************************Ligne 2
        If ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox22.Text <> "" And ComboBox24.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text & Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox22.Text & "_" & ComboBox24.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        '***********************************************Ligne 3
        If ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox17.Text <> "" And ComboBox19.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text & Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox17.Text & "_" & ComboBox19.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        '***********************************************Ligne 4
        If ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker1.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker2.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker3.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker4.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        If ComboBox25.Text <> "" And ComboBox26.Text <> "" Then
            cmd = New OleDbCommand("INSERT INTO TIME_ ([ID_TIME], [DATE], [PERIODE]) VALUES (@CODE_SALLE, @ID_TIME, @module)", con)
            cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text & Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = Strings.Left(DateTimePicker5.Value.ToString(), 10)
            cmd.Parameters.Add(New OleDbParameter("@module", OleDbType.VarChar)).Value = ComboBox25.Text & "_" & ComboBox26.Text
            cmd.ExecuteNonQuery()
        End If
        '******************************************************
        '******************************************************        'initialisation de table TABLES_SALLE********************************
        Dim longp, longem, i, j As Integer
        Dim idtim, place As New DataTable
        adapter = New OleDbDataAdapter("SELECT * FROM PLACE", con)
        adapter.Fill(place)
        adapter = New OleDbDataAdapter("SELECT * FROM TIME_", con)
        adapter.Fill(idtim)
        cmd = New OleDbCommand("SELECT COUNT(ID_PLACE) FROM PLACE", con)
        longp = Convert.ToInt32(cmd.ExecuteScalar())
        cmd = New OleDbCommand("SELECT COUNT(ID_TIME) FROM TIME_", con)
        longem = Convert.ToInt32(cmd.ExecuteScalar())
        FIRST_PAGE.Show()
        For i = 1 To longp - 1
            For j = 1 To longem - 1
                cmd = New OleDbCommand("INSERT INTO TABLES_SALLES ([ID_PLACE],[ID_TIME],[VAL_AFF]) VALUES (@ID_PLACE,@ID_TIME,@VAL)", con)
                cmd.Parameters.Add(New OleDbParameter("@ID_PLACE", OleDbType.VarChar)).Value = place.Rows(i).Item(0)
                cmd.Parameters.Add(New OleDbParameter("@ID_TIME", OleDbType.VarChar)).Value = idtim.Rows(j).Item(0)
                cmd.Parameters.Add(New OleDbParameter("@VAL", OleDbType.VarChar)).Value = 1
                cmd.ExecuteNonQuery()
            Next
        Next
        FIRST_PAGE.Hide()
        '**********************************************
        con.Close()
    End Sub

    Private Sub EMPLOI_DE_TEMPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim max As Integer
        con.Open()
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox1.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox2.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox3.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox4.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox5.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox6.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox7.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox8.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox9.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox10.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox11.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox12.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox13.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox14.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox15.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox16.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox20.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox23.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox21.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        'combobx de module
        cmd = New OleDbCommand("SELECT COUNT(*) FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM MODULES WHERE Niveau = '" & INITIALISATION.ComboBox27.Text & "' AND Sem = '" & INITIALISATION.ComboBox22.Text & "';", con)
        adapter.Fill(dtmdls)
        For j As Integer = 0 To max - 1
            ComboBox18.Items.Add(dtmdls.Rows(j).Item(4))
        Next
        '********************
        con.Close()
        ComboBox33.Items.Add("Dimanche")
        ComboBox33.Items.Add("Lundi")
        ComboBox33.Items.Add("Mardi")
        ComboBox33.Items.Add("Mercredi")
        ComboBox33.Items.Add("Jeudi")
        ComboBox35.Items.Add("Dimanche")
        ComboBox35.Items.Add("Lundi")
        ComboBox35.Items.Add("Mardi")
        ComboBox35.Items.Add("Mercredi")
        ComboBox35.Items.Add("Jeudi")
        ComboBox32.Items.Add("Dimanche")
        ComboBox32.Items.Add("Lundi")
        ComboBox32.Items.Add("Mardi")
        ComboBox32.Items.Add("Mercredi")
        ComboBox32.Items.Add("Jeudi")
        ComboBox34.Items.Add("Dimanche")
        ComboBox34.Items.Add("Lundi")
        ComboBox34.Items.Add("Mardi")
        ComboBox34.Items.Add("Mercredi")
        ComboBox34.Items.Add("Jeudi")
        ComboBox36.Items.Add("Dimanche")
        ComboBox36.Items.Add("Lundi")
        ComboBox36.Items.Add("Mardi")
        ComboBox36.Items.Add("Mercredi")
        ComboBox36.Items.Add("Jeudi")
        con.Open()
        'combobx de periode

        cmd = New OleDbCommand("SELECT COUNT(*) FROM HORAIRE;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM HORAIRE;", con)
        adapter.Fill(dt)
        For j As Integer = 0 To max - 1
            ComboBox27.Items.Add(dt.Rows(j).Item(0))
        Next
        '********************
        'combobx de periode
        cmd = New OleDbCommand("SELECT COUNT(*) FROM HORAIRE;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM HORAIRE;", con)
        adapter.Fill(dt)
        For j As Integer = 0 To max - 1
            ComboBox29.Items.Add(dt.Rows(j).Item(0))
        Next
        '********************
        'combobx de periode
        cmd = New OleDbCommand("SELECT COUNT(*) FROM HORAIRE;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM HORAIRE;", con)
        adapter.Fill(dt)
        For j As Integer = 0 To max - 1
            ComboBox22.Items.Add(dt.Rows(j).Item(0))
        Next
        '********************
        'combobx de periode
        cmd = New OleDbCommand("SELECT COUNT(*) FROM HORAIRE;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM HORAIRE;", con)
        adapter.Fill(dt)
        For j As Integer = 0 To max - 1
            ComboBox19.Items.Add(dt.Rows(j).Item(0))
        Next
        '********************
        'combobx de periode
        cmd = New OleDbCommand("SELECT COUNT(*) FROM HORAIRE;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM HORAIRE;", con)
        adapter.Fill(dt)
        For j As Integer = 0 To max - 1
            ComboBox17.Items.Add(dt.Rows(j).Item(0))
        Next
        '********************
        'combobx de periode
        cmd = New OleDbCommand("SELECT COUNT(*) FROM HORAIRE;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM HORAIRE;", con)
        adapter.Fill(dt)
        For j As Integer = 0 To max - 1
            ComboBox26.Items.Add(dt.Rows(j).Item(0))
        Next
        '********************
        'combobx de periode
        cmd = New OleDbCommand("SELECT COUNT(*) FROM HORAIRE;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM HORAIRE;", con)
        adapter.Fill(dt)
        For j As Integer = 0 To max - 1
            ComboBox25.Items.Add(dt.Rows(j).Item(0))
        Next
        '********************
        'combobx de periode
        cmd = New OleDbCommand("SELECT COUNT(*) FROM HORAIRE;", con)
        max = Convert.ToInt32(cmd.ExecuteScalar())
        adapter = New OleDbDataAdapter("SELECT * FROM HORAIRE;", con)
        adapter.Fill(dt)
        For j As Integer = 0 To max - 1
            ComboBox24.Items.Add(dt.Rows(j).Item(0))
        Next
        con.Close()
        '********************
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DateTimePicker3.Enabled = False
        DateTimePicker4.Enabled = False
        DateTimePicker5.Enabled = False
        ComboBox32.Enabled = False
        ComboBox33.Enabled = False
        ComboBox34.Enabled = False
        ComboBox35.Enabled = False
        ComboBox36.Enabled = False
        AFFECTATION.BunifuThinButton224.ButtonText = ComboBox33.Text
        AFFECTATION.BunifuThinButton220.ButtonText = ComboBox35.Text
        AFFECTATION.BunifuThinButton216.ButtonText = ComboBox36.Text
        AFFECTATION.BunifuThinButton212.ButtonText = ComboBox34.Text
        AFFECTATION.BunifuThinButton28.ButtonText = ComboBox32.Text
    End Sub

    Private Sub BunifuThinButton29_Click(sender As Object, e As EventArgs) Handles BunifuThinButton29.Click
        adapter = New OleDbDataAdapter("SELECT * FROM SALLES_MAX", con)
        adapter.Fill(dts)
        con.Open()
        LOADING.BunifuProgressBar5.Value = 1
        For i = 0 To dts.Rows.Count - 1
            For j = 1 To dts.Rows(i).Item(1)
                cmd = New OleDbCommand("INSERT INTO PLACE ([ID_PLACE],[CODE_SALLE],[TABLE]) VALUES (@ID_PLACE,@CODE_SALLE,@TABLE)", con)
                cmd.Parameters.Add(New OleDbParameter("@ID_PLACE", OleDbType.VarChar)).Value = dts.Rows(i).Item(0) & j
                cmd.Parameters.Add(New OleDbParameter("@CODE_SALLE", OleDbType.VarChar)).Value = dts.Rows(i).Item(0)
                cmd.Parameters.Add(New OleDbParameter("@TABLE", OleDbType.VarChar)).Value = j
                cmd.ExecuteNonQuery()
                LOADING.BunifuProgressBar5.Value = LOADING.BunifuProgressBar5.Value + dts.Rows(i).Item(1) / 100
            Next
        Next
        MsgBox("done")
        con.Close()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class