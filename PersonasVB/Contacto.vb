Public Class Contacto
    Inherits Persona
    Private telefono_ As String
    Private email_ As String

    Public Property Telefono
        Get
            Return telefono_

        End Get

        Set
            telefono_ = Value
        End Set
    End Property

    Public Property Email
        Get
            Return email_
        End Get

        Set
            email_ = Value
        End Set

    End Property

    Public Sub New()
        telefono_ = ""
        email_ = ""
        ApPaterno_ = ""
        ApMaterno_ = ""
        nombre_ = ""
        Nacimiento_ = DateTime.Now
    End Sub
    Public Sub New(tel As String, correo As String, nombres As String, ApePaterno As String, ApeMaterno As String, FechaNacimiento As DateTime)
        telefono_ = tel
        email_ = correo
        ApPaterno_ = ApePaterno
        ApMaterno_ = ApeMaterno
        nombre_ = nombres
        Nacimiento_ = FechaNacimiento
    End Sub

    Public Overloads Function toString() As String
        Return nombre_ + " " + ApPaterno_ + " " + ApMaterno_ + " " + Nacimiento_ + "," + telefono_ + ", " + email_
    End Function


End Class
