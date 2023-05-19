Imports System.Threading

Public NotInheritable Class ThreadTask

    Public Shared callback As Threading.TimerCallback

    Public Shared timer
    Public Shared Function ThreadPrueba()

        callback = AddressOf tarea
        timer = New Timer(callback, Nothing, TimeSpan.Zero, TimeSpan.FromSeconds(2))
    End Function

    Public Shared Sub tarea(state As Object)

        Console.WriteLine("Tarea ejecutada")

    End Sub
End Class
