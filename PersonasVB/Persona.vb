Public Class Persona
    Protected nombre_ As String
    Protected ApPaterno_ As String
    Protected ApMaterno_ As String
    Protected Nacimiento_ As DateTime

    Public Property Nombre

        Get
            Return nombre_
        End Get

        Set
            nombre_ = Value
        End Set

    End Property

    Public Property ApellidoPaterno
        Get
            Return ApPaterno_
        End Get

        Set
            ApPaterno_ = Value
        End Set

    End Property

    Public Property ApellidoMaterno

        Get
            Return ApMaterno_
        End Get

        Set
            ApMaterno_ = Value
        End Set
        End Property
    Public Property FechaNacimiento

        Get
            Return Nacimiento_
        End Get

        Set
            Nacimiento_ = Value
        End Set


    End Property



    Public Sub New()
        nombre_ = ""
        ApPaterno_ = ""
        ApMaterno_ = ""
        Nacimiento_ = DateTime.Now
    End Sub
    Public Sub New(nombres As String, ApePaterno As String, ApeMaterno As String, FNacimiento As DateTime)
        nombre_ = nombres
        ApPaterno_ = ApePaterno
        ApMaterno_ = ApeMaterno
        Nacimiento_ = FNacimiento
    End Sub
    Public Overloads Function ToString() As String

        Return nombre_ + " " + ApPaterno_ + " " + ApMaterno_ + " " + Nacimiento_
    End Function

    Public Function RFC() As String
        Dim resultado As String = ""
        resultado = ApPaterno_.Substring(0, 1)

        For i As Integer = 1 To ApPaterno_.Length Step 1

            Dim vocal As String = ApPaterno_.Substring(i, 1)
            If (vocal = "a" Or vocal = "á") Then
                resultado += "A"
                i = ApPaterno_.Length + 1

            ElseIf (vocal = "e" Or vocal = "é") Then
                resultado += "E"
                i = ApPaterno_.Length + 1

            ElseIf (vocal = "i" Or vocal = "í") Then
                resultado += "I"
                i = ApPaterno_.Length + 1

            ElseIf (vocal = "o" Or vocal = "ó") Then
                resultado += "O"
                i = ApPaterno_.Length + 1

            ElseIf (vocal = "ú" Or vocal = "u" Or vocal = "ü") Then
                resultado += "U"
                i = ApPaterno_.Length + 1
            End If
        Next

        If (String.IsNullOrWhiteSpace(ApMaterno_) Or String.IsNullOrEmpty(ApMaterno_)) Then

            resultado += "X"

        Else
            resultado += ApMaterno_.Substring(0, 1)
        End If

        resultado += nombre_.Substring(0, 1)
        resultado += Nacimiento_.Year.ToString().Substring(2, 2)
        If (Nacimiento_.Month < 10) Then
            resultado += "0"
            resultado += Nacimiento_.Month.ToString()
        Else
            resultado += Nacimiento_.Month.ToString()
        End If
        If (Nacimiento_.Day < 10) Then
            resultado += "0"
            resultado += Nacimiento_.Day.ToString()
        Else
            resultado += Nacimiento_.Day.ToString()
        End If


        Return resultado

    End Function

End Class
