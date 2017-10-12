Public Function Verif_CI(ByVal ci_cadena As String) As Boolean
On Error GoTo Errores
Dim NumComprobador(8) As Integer
Dim ccc_Sumatoria As Integer
Dim digito As Integer
Dim digito_verificador As Integer

'ci_cadena_sin_digito = Mid$(ci_cadena, 1, Len(ci_cadena) - 1)
ccc_Sumatoria = 0
'------------------------------------------------------
'Preestablecemos los valores del número comprobador..
NumComprobador(1) = 2
NumComprobador(2) = 9
NumComprobador(3) = 8
NumComprobador(4) = 7
NumComprobador(5) = 6
NumComprobador(6) = 3
NumComprobador(7) = 4
'------------------------------------------------------


If Len(ci_cadena) = 7 Or Len(ci_cadena) = 8 Then
    
    If Len(ci_cadena) = 7 Then
        ci_cadena = 0 & ci_cadena
    End If
    
    For i = 0 To 7
        digito = Val(Mid$(ci_cadena_sin_digito, i + 1, 1))
        ccc_Sumatoria = ccc_Sumatoria + (NumComprobador(i + 1) * digito)
    Next
    
    If ccc_Sumatoria Mod 10 = 0 Then
        digito_verificador = ccc_Sumatoria Mod 10
    Else
        digito_verificador = 10 - (ccc_Sumatoria Mod 10)
    End If

    If digito_verificador = Val(Mid$(ci_cadena_sin_digito, i + 1, 1)) Then
        Verif_CI = True
    Else
        Verif_CI = False
    End If

Else
    Verif_CI = False
End If

Exit Function
Errores:
    Verif_CI = False
End Function