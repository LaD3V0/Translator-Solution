Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function ItalianLang(ByVal ItalianTrans As String)
        Dim ItalianText As String
        If radBrother.Checked And (cboLang.SelectedIndex = 1) = True Then
            ItalianText = "Fratello"
        ElseIf radFather.Checked And (cboLang.SelectedIndex = 1) = True Then
            ItalianText = "Padre"
        ElseIf RadMother.Checked And (cboLang.SelectedIndex = 1) = True Then
            ItalianText = "Madre"
        ElseIf radSister.Checked And (cboLang.SelectedIndex = 1) = True Then
            ItalianText = "Sorella"
        End If
        Return ItalianTrans
    End Function
    Private Function SpanishLang(ByVal SpanishTrans As String)
        Dim SpanishText As String
        If radBrother.Checked And (cboLang.SelectedIndex = 2) = True Then
            SpanishText = "Hermano"
        ElseIf radFather.Checked And (cboLang.SelectedIndex = 2) = True Then
            SpanishText = "Padre"
        ElseIf RadMother.Checked And (cboLang.SelectedIndex = 2) = True Then
            SpanishText = "Madre"
        ElseIf radSister.Checked And (cboLang.SelectedIndex = 2) = True Then
            SpanishText = "Hermana"
        End If
        Return SpanishTrans
    End Function
    Private Function FrenchLang(ByVal FrnchLang As String)
        Dim FrenchText As String
        If radBrother.Checked And (cboLang.SelectedIndex = 0) = True Then
            FrenchText = "Déranger"
        ElseIf radFather.Checked And (cboLang.SelectedIndex = 0) = True Then
            FrenchText = "Père"
        ElseIf RadMother.Checked And (cboLang.SelectedIndex = 0) = True Then
            FrenchText = "Mère"
        ElseIf radSister.Checked And (cboLang.SelectedIndex = 0) = True Then
            FrenchText = "Sœur"
        End If
        Return FrnchLang
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click

        Dim translatedItal As String
        Dim translatedspan As String
        Dim translatedFrench As String

        ItalianLang(translatedItal)
        SpanishLang(translatedspan)
        FrenchLang(translatedFrench)

        lblTranslated.Text = FrenchLang(translatedFrench)

        lblTranslated.Text = SpanishLang(translatedspan)

        lblTranslated.Text = ItalianLang(translatedItal)

    End Sub
End Class
