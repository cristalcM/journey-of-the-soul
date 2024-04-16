[System.Serializable]

public class playerdata
{
    public float [] posicion = new float[3];
    public Item[] inventario;
    public playerdata(movimientopersonaje player)
    {
        posicion[0] = player.transform.position.x;
        posicion[1] = player.transform.position.y;
        posicion[2] = player.transform.position.z;

    }
    public playerdata(playerinventory playeri)
    {
        inventario = playeri.items;
    }

}
