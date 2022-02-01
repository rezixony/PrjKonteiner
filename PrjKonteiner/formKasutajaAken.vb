Public Class formKasutajaAken

    Private Sub btnPoora1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoora1.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'Teostame teksti pooramise kasutades parametriseerimata funktsiooni pooraTejst ning liidese atribuudi strTekst
        '---omistame liidese atribuudile tekstivaljal oleva vaartuse
        pooraja.strTekst = txtSisendTekst.Text
        '---kasutades komponendis sisalduvat funktsiooni vaartustame tekstivalja txtValjundText1
        txtValjundTekst1.Text = pooraja.pooraTekst()

    End Sub

    Private Sub btnPoora2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoora2.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CTekstiPooraja


        'Teostame teksti pooramise kasutades parametriseerimata funktsiooni pooraTejst ning liidese atribuudi strTekst
        '---omistame liidese atribuudile tekstivaljal oleva vaartuse
        pooraja.teisendaTekst(txtSisendTekst.Text)
        '---kasutades komponendis sisalduvat funktsiooni vaartustame tekstivalja txtValjundText1
        txtValjundTekst2.Text = pooraja.strTekst

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        'vajatus nupul btnStart lulitab taimeri timerUuenda sisse
        timerUuenda.Enabled = True
        'vajatus nupul btnStart keelab vajurused nupul btnStart
        btnStart.Enabled = False
        btnStopp.Enabled = True

    End Sub

    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click

        'vajatus nupul btnStopp lulitab taimeri timerUuenda valja
        'timerUuenda.Enabled = False
        'vajatus nupul btnStop keelab vajurused nupul btnStop
        btnStopp.Enabled = False
        btnStart.Enabled = True
        
    End Sub

    Private Sub timerUuenda_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerUuenda.Tick

        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        'Teostame teksti pooramise kasutades parametriseerimata funktsiooni pooraTejst ning liidese atribuudi strTekst
        '---omistame liidese atribuudile tekstivaljal oleva vaartuse
        pooraja.strTekst = txtSisendTekst.Text
        '---kasutades komponendis sisalduvat funktsiooni vaartustame tekstivalja txtValjundText1
        txtValjundTekst1.Text = pooraja.pooraTekst

    End Sub

    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged
        txtPikkus.Text = Len(txtSisendTekst.Text)

        Dim taisHaalikud As Char() = {"e"c, "y"c, "u"c, "i"c, "o"c, "ü"c, "õ"c, "a"c, "ö"c, "ä"c}
        Dim i As Integer
        Dim j As Integer
        Dim taisHaalikuteArv As Integer


        For i = 0 To (Len(txtSisendTekst.Text) - 1)
            For j = 0 To (Len(taisHaalikud) - 1)
                If (txtSisendTekst.Text(i) = taisHaalikud(j)) Then
                    taisHaalikuteArv = taisHaalikuteArv + 1
                End If
            Next
        Next

        txtTaisHaalik.Text = taisHaalikuteArv
    End Sub

    Private Sub btnPoora12_Click(sender As Object, e As EventArgs) Handles btnPoora12.Click

        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja

        'Teostame teksti pooramise kasutades parametriseerimata funktsiooni pooraTejst ning liidese atribuudi strTekst
        '---omistame liidese atribuudile tekstivaljal oleva vaartuse
        pooraja.strTekst = txtSisendTekst.Text

        'Seadistame referentsmuutuja viitama uuele objektile
        txtValjundTekst12.Text = pooraja.pooraTekst()



    End Sub

    Private Sub btnPoora22_Click(sender As Object, e As EventArgs) Handles btnPoora22.Click
        'Objekti loomine liidese baasil; referentsmuutuja pooraja deklaratsioon
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        'Seadistame referentsmuutuja viitama uuele objektile
        pooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja


        'Teostame teksti pooramise kasutades parametriseerimata funktsiooni pooraTejst ning liidese atribuudi strTekst
        '---omistame liidese atribuudile tekstivaljal oleva vaartuse
        pooraja.teisendaTekst(txtSisendTekst.Text)
        '---kasutades komponendis sisalduvat funktsiooni vaartustame tekstivalja txtValjundText1
        txtValjundTekst22.Text = pooraja.strTekst
    End Sub
End Class
