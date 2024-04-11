namespace libs;

public class Horse : GameObject {

    public Horse () : base(){
        this.Type = GameObjectType.Horse;
        this.CharRepresentation = '♘';
        this.Color = ConsoleColor.DarkGreen;
    }
     public override void Move(int dx, int dy) {
        _prevPosX = _posX;
        _prevPosY = _posY;
        _posX += dx;
        _posY += dy;
    }
}

//Horse = 3