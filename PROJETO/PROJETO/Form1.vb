Public Class Projeto1
    Dim nvsal, totsum, contma, contmb, contmc, mediamasa, mediamasb, mediamasc, contfa, contfb, contfc, mediafea, mediafeb, mediafec, maiorsal, menorsal, cont, smpam, smpbm, smpcm, smpaf, smpbf, smpcf As Double
    Dim sexo As String
    Private Sub cmdcalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcalc.Click

        cont += 1
        'verifica se é da categoria A
        sexo = txtsexo.Text
        If CDbl(txtpec.Text) <= 30 Then
            'faz a media de peça masculina de A

            Select sexo
                Case "m"

                    contma += 1
                    smpam += CDbl(txtpec.Text)
                    mediamasa = smpam / contma
                    lblmpechA.Text = CStr(mediamasa)

        'faz a media de peça feminina de A
            case "f"
                    contfa += 1
                    smpaf += CDbl(txtpec.Text)
                    mediafea = smpaf / contfa
                    lblmpecmA.Text = CStr(mediafea)
            End select
        nvsal = CDbl(txtsm.Text)
        Else

        'verifica se é da categoria B
        If CDbl(txtpec.Text) < 35 And CDbl(txtpec.Text) > 30 Then
            'faz a media de peça masculina de B

            Select Case sexo
                Case "m"
                    contmb += 1
                    smpbm += CDbl(txtpec.Text)
                    mediamasb = smpbm / contmb
                    lblmpechB.Text = CStr(mediamasb)

                    'faz a media de peça feminina de B
                Case "f"
                    contfb += 1
                    smpbf += CDbl(txtpec.Text)
                    mediafeb = smpbf / contfb
                    lblmpecmB.Text = CStr(mediafeb)
            End Select
            nvsal = CDbl(txtsm.Text) + (CDbl(txtpec.Text) - 30) * (CDbl(txtsm.Text) * 3 / 100)


            'verifica se é da categoria C
        Else


            Select Case sexo
                Case "m"
                    contmc += 1
                    smpcm += CDbl(txtpec.Text)
                    mediamasc = smpcm / contmc
                    lblmpechC.Text = CStr(mediamasc)

                    'faz a media de peça feminina de C
                Case "f"
                    contfc += 1
                    smpcf += CDbl(txtpec.Text)
                    mediafec = smpcf / contfc
                    lblmpecmC.Text = CStr(mediafec)
            End Select
            nvsal = CDbl(txtsm.Text) + (CDbl(txtpec.Text) - 30) * (CDbl(txtsm.Text) * 5 / 100)
        End If
        End If
        'fim das analises de categoria

        'serve para contralar o codigo do menor salario
        If cont = 1 Then
            menorsal = nvsal
        End If

        'verifica se o novo salario é maior
        If nvsal > maiorsal Then
            maiorsal = nvsal
            lblcdm.Text = txtcodop.Text
        End If
        'verifica se o novo salario é maior
        If menorsal >= nvsal Then
            menorsal = nvsal
            lblcdmn.Text = txtcodop.Text
        End If

        'manda as informaçoes para o app
        lblsaln.Text = CStr(nvsal)
        totsum += nvsal
        lblss.Text = CStr(totsum)

    End Sub

    Private Sub Projeto1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
