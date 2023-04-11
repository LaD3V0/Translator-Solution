Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function ItalianLang() As String
        Dim ItalianText As String = String.Empty
        If radBrother.Checked And (cboLang.SelectedIndex = 2) = True Then
            ItalianText = "Fratello"
        ElseIf radFather.Checked And (cboLang.SelectedIndex = 2) = True Then
            ItalianText = "Padre"
        ElseIf RadMother.Checked And (cboLang.SelectedIndex = 2) = True Then
            ItalianText = "Madre"
        ElseIf radSister.Checked And (cboLang.SelectedIndex = 2) = True Then
            ItalianText = "Sorella"
        End If
        Return ItalianText
    End Function
    Private Function SpanishLang() As String
        Dim SpanishText As String = String.Empty
        If radBrother.Checked And (cboLang.SelectedIndex = 1) = True Then
            SpanishText = "Hermano"
        ElseIf radFather.Checked And (cboLang.SelectedIndex = 1) = True Then
            SpanishText = "Padre"
        ElseIf RadMother.Checked And (cboLang.SelectedIndex = 1) = True Then
            SpanishText = "Madre"
        ElseIf radSister.Checked And (cboLang.SelectedIndex = 1) = True Then
            SpanishText = "Hermana"
        End If
        Return SpanishText
    End Function
    Private Function FrenchLang() As String
        Dim FrenchText As String = String.Empty
        If radBrother.Checked And (cboLang.SelectedIndex = 0) = True Then
            FrenchText = "Déranger"
        ElseIf radFather.Checked And (cboLang.SelectedIndex = 0) = True Then
            FrenchText = "Père"
        ElseIf RadMother.Checked And (cboLang.SelectedIndex = 0) = True Then
            FrenchText = "Mère"
        ElseIf radSister.Checked And (cboLang.SelectedIndex = 0) = True Then
            FrenchText = "Sœur"
        End If
        Return FrenchText
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click

        If cboLang.Text = "French" Then
            lblTranslated.Text = FrenchLang()
        ElseIf cboLang.Text = "Spanish" Then
            lblTranslated.Text = SpanishLang()
        ElseIf cboLang.Text = "Italian" Then
            lblTranslated.Text = ItalianLang()
        End If
    End Sub
    Private Sub ClearOuput(sender As Object, e As EventArgs) Handles radBrother.CheckedChanged,
    radFather.CheckedChanged, radSister.CheckedChanged, RadMother.CheckedChanged, cboLang.SelectedIndexChanged
        lblTranslated.Text = String.Empty
    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Are you REALLY REALLY sure you want to exit?", "Learn More Translations", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
