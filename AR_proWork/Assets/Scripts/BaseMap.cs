[SerializeField] private Texture texture;

void Start()
{
    GetComponent<Renderer>().material.SetTexture("_BaseMap", texture);
}