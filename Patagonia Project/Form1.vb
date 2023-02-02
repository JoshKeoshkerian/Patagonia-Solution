Option Explicit On
Option Infer Off
Option Strict On
'Name:    Patagonia Project'
'Purpose: Touch Screen Interface to do purchases'
'Coder:   Joshua Keoshkerian on 1/19/22'

Imports System.Security.Cryptography

Public Class frmMain

    Dim Hoodies As Double
    Dim Shirts As Double
    Dim Pants As Double
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub radHoodies_CheckedChanged(sender As Object, e As EventArgs) Handles radHoodies.CheckedChanged, radSweatPants.CheckedChanged, radShirts.CheckedChanged, radXXXL.CheckedChanged, radXXL.CheckedChanged, radXL.CheckedChanged, radL.CheckedChanged, radBlue.CheckedChanged, radRed.CheckedChanged, radWhite.CheckedChanged, radNoClothes.CheckedChanged, radNoColor.CheckedChanged

        If radHoodies.Checked = True And radRed.Checked = True And radXXXL.Checked = True Then
            picHoodies.Image = My.Resources.RedHoodie
            lblHoodies.Text = "1"
            Hoodies = 80
        ElseIf radHoodies.Checked = True And radRed.Checked = True And radXXL.Checked = True Then
            picHoodies.Image = My.Resources.RedHoodie
            lblHoodies.Text = "1"
            Hoodies = 70
        ElseIf radHoodies.Checked = True And radRed.Checked = True And radXL.Checked = True Then
            picHoodies.Image = My.Resources.RedHoodie
            lblHoodies.Text = "1"
            Hoodies = 45
        ElseIf radHoodies.Checked = True And radRed.Checked = True And radL.Checked = True Then
            picHoodies.Image = My.Resources.RedHoodie
            lblHoodies.Text = "1"
            Hoodies = 30
        ElseIf radHoodies.Checked = True And radBlue.Checked = True And radXXXL.Checked = True Then
            picHoodies.Image = My.Resources.BlueHoodie
            lblHoodies.Text = "1"
            Hoodies = 80
        ElseIf radHoodies.Checked = True And radBlue.Checked = True And radXXL.Checked = True Then
            picHoodies.Image = My.Resources.BlueHoodie
            lblHoodies.Text = "1"
            Hoodies = 70
        ElseIf radHoodies.Checked = True And radBlue.Checked = True And radXL.Checked = True Then
            picHoodies.Image = My.Resources.BlueHoodie
            lblHoodies.Text = "1"
            Hoodies = 45
        ElseIf radHoodies.Checked = True And radBlue.Checked = True And radL.Checked = True Then
            picHoodies.Image = My.Resources.BlueHoodie
            lblHoodies.Text = "1"
            Hoodies = 30
        ElseIf radHoodies.Checked = True And radWhite.Checked = True And radXXXL.Checked = True Then
            picHoodies.Image = My.Resources.WhiteHoodie
            lblHoodies.Text = "1"
            Hoodies = 80
        ElseIf radHoodies.Checked = True And radWhite.Checked = True And radXXL.Checked = True Then
            picHoodies.Image = My.Resources.WhiteHoodie
            lblHoodies.Text = "1"
            Hoodies = 70
        ElseIf radHoodies.Checked = True And radWhite.Checked = True And radXL.Checked = True Then
            picHoodies.Image = My.Resources.WhiteHoodie
            lblHoodies.Text = "1"
            Hoodies = 45
        ElseIf radHoodies.Checked = True And radWhite.Checked = True And radL.Checked = True Then
            picHoodies.Image = My.Resources.WhiteHoodie
            lblHoodies.Text = "1"
            Hoodies = 30
        End If

        If radShirts.Checked = True And radRed.Checked = True And radXXXL.Checked = True Then
            picShirts.Image = My.Resources.RedShirt
            lblShirts.Text = "1"
            Shirts = 50
        ElseIf radShirts.Checked = True And radRed.Checked = True And radXXL.Checked = True Then
            picShirts.Image = My.Resources.RedShirt
            lblShirts.Text = "1"
            Shirts = 40
        ElseIf radShirts.Checked = True And radRed.Checked = True And radXL.Checked = True Then
            picShirts.Image = My.Resources.RedShirt
            lblShirts.Text = "1"
            Shirts = 30
        ElseIf radShirts.Checked = True And radRed.Checked = True And radL.Checked = True Then
            picShirts.Image = My.Resources.RedShirt
            lblShirts.Text = "1"
            Shirts = 20
        ElseIf radShirts.Checked = True And radBlue.Checked = True And radXXXL.Checked = True Then
            picShirts.Image = My.Resources.BlueShirt
            lblShirts.Text = "1"
            Shirts = 50
        ElseIf radShirts.Checked = True And radBlue.Checked = True And radXXL.Checked = True Then
            picShirts.Image = My.Resources.BlueShirt
            lblShirts.Text = "1"
            Shirts = 40
        ElseIf radShirts.Checked = True And radBlue.Checked = True And radXL.Checked = True Then
            picShirts.Image = My.Resources.BlueShirt
            lblShirts.Text = "1"
            Shirts = 30
        ElseIf radShirts.Checked = True And radBlue.Checked = True And radL.Checked = True Then
            picShirts.Image = My.Resources.BlueShirt
            lblShirts.Text = "1"
            Shirts = 20
        ElseIf radShirts.Checked = True And radWhite.Checked = True And radXXXL.Checked = True Then
            picShirts.Image = My.Resources.WhiteShirt
            lblShirts.Text = "1"
            Shirts = 50
        ElseIf radShirts.Checked = True And radWhite.Checked = True And radXXL.Checked = True Then
            picShirts.Image = My.Resources.WhiteShirt
            lblShirts.Text = "1"
            Shirts = 40
        ElseIf radShirts.Checked = True And radWhite.Checked = True And radXL.Checked = True Then
            picShirts.Image = My.Resources.WhiteShirt
            lblShirts.Text = "1"
            Shirts = 30
        ElseIf radShirts.Checked = True And radWhite.Checked = True And radL.Checked = True Then
            picShirts.Image = My.Resources.WhiteShirt
            lblShirts.Text = "1"
            Shirts = 20
        End If

        If radSweatPants.Checked = True And radRed.Checked = True And radXXXL.Checked = True Then
            picSweatpants.Image = My.Resources.RedPants
            lblSweatpants.Text = "1"
            Pants = 100
        ElseIf radSweatPants.Checked = True And radRed.Checked = True And radXXL.Checked = True Then
            picSweatpants.Image = My.Resources.RedPants
            lblSweatpants.Text = "1"
            Pants = 80
        ElseIf radSweatPants.Checked = True And radRed.Checked = True And radXL.Checked = True Then
            picSweatpants.Image = My.Resources.RedPants
            lblSweatpants.Text = "1"
            Pants = 60
        ElseIf radSweatPants.Checked = True And radRed.Checked = True And radL.Checked = True Then
            picSweatpants.Image = My.Resources.RedPants
            lblSweatpants.Text = "1"
            Pants = 40
        ElseIf radSweatPants.Checked = True And radBlue.Checked = True And radXXXL.Checked = True Then
            picSweatpants.Image = My.Resources.BluePants
            lblSweatpants.Text = "1"
            Pants = 100
        ElseIf radSweatPants.Checked = True And radBlue.Checked = True And radXXL.Checked = True Then
            picSweatpants.Image = My.Resources.BluePants
            lblSweatpants.Text = "1"
            Pants = 80
        ElseIf radSweatPants.Checked = True And radBlue.Checked = True And radXL.Checked = True Then
            picSweatpants.Image = My.Resources.BluePants
            lblSweatpants.Text = "1"
            Pants = 60
        ElseIf radSweatPants.Checked = True And radBlue.Checked = True And radL.Checked = True Then
            picSweatpants.Image = My.Resources.BluePants
            lblSweatpants.Text = "1"
            Pants = 40
        ElseIf radSweatPants.Checked = True And radWhite.Checked = True And radXXXL.Checked = True Then
            picSweatpants.Image = My.Resources.WhitePants
            lblSweatpants.Text = "1"
            Pants = 100
        ElseIf radSweatPants.Checked = True And radWhite.Checked = True And radXXL.Checked = True Then
            picSweatpants.Image = My.Resources.WhitePants
            lblSweatpants.Text = "1"
            Pants = 80
        ElseIf radSweatPants.Checked = True And radWhite.Checked = True And radXL.Checked = True Then
            picSweatpants.Image = My.Resources.WhitePants
            lblSweatpants.Text = "1"
            Pants = 60
        ElseIf radSweatPants.Checked = True And radWhite.Checked = True And radL.Checked = True Then
            picSweatpants.Image = My.Resources.WhitePants
            lblSweatpants.Text = "1"
            Pants = 40
        End If

        If radNoClothes.Checked = True Then
            picHoodies.Image = My.Resources.Actual_Design
            picShirts.Image = My.Resources.Actual_Design
            picSweatpants.Image = My.Resources.Actual_Design
            lblShirts.Text = String.Empty
            lblHoodies.Text = String.Empty
            lblSweatpants.Text = String.Empty
            Hoodies = 0
            Pants = 0
            Shirts = 0
            picLogo.Visible = False
        End If

        If radNoColor.Checked = True And radHoodies.Checked = True Then
            picHoodies.Image = My.Resources.Actual_Design
            Hoodies = 0
            lblHoodies.Text = String.Empty
        ElseIf radNoColor.Checked = True And radShirts.Checked = True Then
            picShirts.Image = My.Resources.Actual_Design
            Shirts = 0
            lblShirts.Text = String.Empty
            picLogo.Visible = False
        ElseIf radNoColor.Checked = True And radSweatPants.Checked = True Then
            picSweatpants.Image = My.Resources.Actual_Design
            Pants = 0
            lblSweatpants.Text = String.Empty
        End If

        lblTotalDue.Text = (Hoodies + Pants + Shirts).ToString("C2")
    End Sub

    Private Sub picLeftHoodies_Click(sender As Object, e As EventArgs) Handles picLeftHoodies.Click
        lblHoodies.Text = (Val(lblHoodies.Text) - 1).ToString()
        Hoodies = Hoodies * ((Val(lblHoodies.Text) / (Val(lblHoodies.Text) + 1)))
        lblTotalDue.Text = (Hoodies + Shirts + Pants).ToString("C2")

    End Sub

    Private Sub picRightHoodies_Click(sender As Object, e As EventArgs) Handles picRightHoodies.Click
        lblHoodies.Text = (Val(lblHoodies.Text) + 1).ToString()
        Hoodies = Hoodies * ((Val(lblHoodies.Text) / (Val(lblHoodies.Text) - 1)))
        lblTotalDue.Text = (Hoodies + Shirts + Pants).ToString("C2")
    End Sub

    Private Sub picLeftShirts_Click(sender As Object, e As EventArgs) Handles picLeftShirts.Click
        lblShirts.Text = (Val(lblShirts.Text) - 1).ToString()
        Shirts = Shirts * ((Val(lblShirts.Text) / (Val(lblShirts.Text) + 1)))
        lblTotalDue.Text = (Hoodies + Shirts + Pants).ToString("C2")

    End Sub

    Private Sub picRightShirts_Click(sender As Object, e As EventArgs) Handles picRightShirts.Click
        lblShirts.Text = (Val(lblShirts.Text) + 1).ToString()
        Shirts = Shirts * ((Val(lblShirts.Text) / (Val(lblShirts.Text) - 1)))
        lblTotalDue.Text = (Hoodies + Shirts + Pants).ToString("C2")
    End Sub

    Private Sub picLeftSweatpants_Click(sender As Object, e As EventArgs) Handles picLeftSweatpants.Click
        lblSweatpants.Text = (Val(lblSweatpants.Text) - 1).ToString()
        Pants = Pants * ((Val(lblSweatpants.Text) / (Val(lblSweatpants.Text) + 1)))
        lblTotalDue.Text = (Hoodies + Shirts + Pants).ToString("C2")
    End Sub

    Private Sub picRightSweatpants_Click(sender As Object, e As EventArgs) Handles picRightSweatpants.Click
        lblSweatpants.Text = (Val(lblSweatpants.Text) + 1).ToString()
        Pants = Pants * ((Val(lblSweatpants.Text) / (Val(lblSweatpants.Text) - 1)))
        lblTotalDue.Text = (Hoodies + Shirts + Pants).ToString("C2")
    End Sub

    Private Sub chkInStore_CheckedChanged(sender As Object, e As EventArgs) Handles chkInStore.CheckedChanged, chkSuperhero.CheckedChanged
        If chkInStore.Checked = True And chkSuperhero.Checked = False Then
            lblTotalDue.Text = ((Hoodies + Pants + Shirts) * 0.9).ToString("C2")
        ElseIf chkInStore.Checked = False And chkSuperhero.Checked = True Then
            lblTotalDue.Text = (Hoodies + Pants + Shirts + (20 * Val(lblShirts.Text))).ToString("C2")
        ElseIf chkInStore.Checked = True And chkSuperhero.Checked = True Then
            lblTotalDue.Text = ((Hoodies + Pants + Shirts + (20 * Val(lblShirts.Text))) * 0.9).ToString("C2")
        ElseIf chkInStore.Checked = False And chkSuperhero.Checked = False Then
            lblTotalDue.Text = (Hoodies + Shirts + Pants).ToString("C2")
        End If

        If chkSuperhero.Checked = True And Val(lblShirts.Text) >= 1 Then
            picLogo.Visible = True
        ElseIf chkSuperhero.Checked = True And Val(lblShirts.Text) < 1 Then
            picLogo.Visible = False
        ElseIf chkSuperhero.Checked = False Then
            picLogo.Visible = False
        End If
    End Sub

    Private Sub btnFinalize_Click(sender As Object, e As EventArgs) Handles btnFinalize.Click
        picShirts.Image = My.Resources.Thank_You
        picLogo.Visible = False
        picSweatpants.Image = My.Resources.Actual_Design
        picSweatpants.Visible = False
        picHoodies.Image = My.Resources.Actual_Design
        btnNewOrder.Visible = True
        picHoodies.Visible = False
        lblFinal.Visible = True
        Label4.Visible = True
        lblFinal.Text = (Hoodies + Pants + Shirts).ToString("C2")
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        picSweatpants.Visible = True
        btnNewOrder.Visible = False
        picHoodies.Image = My.Resources.Actual_Design
        picShirts.Image = My.Resources.Actual_Design
        picSweatpants.Image = My.Resources.Actual_Design
        lblShirts.Text = String.Empty
        lblHoodies.Text = String.Empty
        lblSweatpants.Text = String.Empty
        Hoodies = 0
        Pants = 0
        Shirts = 0
        picLogo.Visible = False
        Label4.Visible = False
        lblFinal.Visible = False
        picHoodies.Visible = True
        radNoClothes.Checked = True
        radNoColor.Checked = True

    End Sub
End Class
