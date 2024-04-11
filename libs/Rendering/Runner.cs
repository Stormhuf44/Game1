namespace libs;

public class Runner : GameObject {
    public Runner () : base() {
        this.Type = GameObjectType.Runner;
        this.CharRepresentation = '♗';
    }

   public override void Move(int dx, int dy)
        {
            _prevPosX = _posX;
            _prevPosY = _posY;
            _posX += dx;
            _posY += dy;
}
}

//Queen = 0