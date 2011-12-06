Imports KaisII.FormGenClasses

Public Class Birth

    Public Sub New()
    End Sub

    Public Sub New(ByVal foreignKey As Integer)
        Me.foreignKey = foreignKey
    End Sub

    Public Property initials As String
    Public Property Q_202 As Lookup
    Public Property Q_203_day As Integer
    Public Property Q_203_month As Integer
    Public Property Q_203_year As Integer
    Public Property Q_204 As Lookup
    Public Property Q_204_other As String
    'Public Property Q_204 As Integer
    'Public Property Q_204_other As String
    'Public Property Q_205 As Integer
    'Public Property Q_206 As Integer
    'Public Property Q_206_day As Lookup
    'Public Property Q_206_month As Lookup
    'Public Property Q_206_year As Integer
    'Public Property Q_206a As Integer
    'Public Property Q_207 As Integer
    'Public Property Q_208 As Integer
    'Public Property Q_208_other As String
    'Public Property Q_208a As Lookup
    'Public Property Q_209 As Lookup
    'Public Property Q_209_other As Lookup
    'Public Property Q_210 As Lookup
    'Public Property Q_210_other As String
    'Public Property Q_211 As Lookup
    'Public Property Q_212 As Lookup
    'Public Property Q_213 As Lookup
    'Public Property Q_214 As Lookup
    'Public Property Q_215 As Lookup
    'Public Property Q_216 As Lookup
    'Public Property Q_217 As Lookup
    'Public Property Q_218 As Lookup
    'Public Property Q_219 As Lookup
    'Public Property Q_220 As Lookup
    'Public Property Q_221 As Lookup
    'Public Property Q_221_other As String
    'Public Property Q_222 As Lookup
    'Public Property Q_223 As Lookup
    'Public Property Q_224 As Lookup
    'Public Property Q_225 As Lookup
    'Public Property Q_225_other As String
    'Public Property Q_226 As Lookup
    'Public Property Q_227 As Lookup
    'Public Property Q_228 As Lookup
    'Public Property Q_229 As Lookup
    'Public Property Q_230 As Lookup
    'Public Property Q_231 As Lookup
    'Public Property Q_232 As Lookup
    'Public Property Q_233 As Lookup
    'Public Property Q_234 As Lookup
    'Public Property Q_235 As Lookup
    'Public Property Q_236 As Lookup
    'Public Property Q_236a As Lookup
    'Public Property Q_236b As Lookup
    'Public Property Q_237_month As Integer
    'Public Property Q_237_year As Integer
    'Public Property Q_238 As Lookup
    'Public Property Q_239_day As Integer
    'Public Property Q_239_month As Integer
    'Public Property Q_239_year As Integer
    Public Property foreignKey As Integer
End Class
