namespace libs;

public class Tower : GameObject {

    public Tower () : base(){
        this.Type = GameObjectType.Tower;
        this.CharRepresentation = '♖';
        
    }
     public override void Move(int dx, int dy) {
        _prevPosX = _posX;
        _prevPosY = _posY;
        _posX += dx;
        _posY += dy;
    }
}

//Tower = 4