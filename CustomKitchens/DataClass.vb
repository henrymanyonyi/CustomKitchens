Public Class DataClass

    Public Shared userInfo

    Public Shared KitchenLayouts() As Object = {(1, "Small L-shaped Kitchen", 250, 180, 3500, 4500, 5750),
        (2, "Medium L-shaped Kitchen", 350, 240, 6500, 7750, 9500),
        (3, "Large L-shaped Kitchen", 450, 350, 8250, 9500, 12500),
        (4, "Small Straight Kitchen", 150, 60, 1000, 1500, 2200),
        (5, "Medium Straight Kitchen", 350, 60, 5250, 6200, 8000),
        (6, "Large Straight Kitchen", 250, 180, 3500, 4500, 5750),
        (7, "Large Island Kitchen", 450, 450, 12500, 15000, 23000)}

    Public Shared selectedLayout As Integer

End Class
