public class Farm
{
    string name;
    double area;
    int animalCount;
    public Farm(string name, double area, int animalCount)
    {
        this.name = name;
        this.area = area;
        this.animalCount =animalCount;
    }
    public void AddAnimals(int count)
    {
        this.animalCount = this.animalCount + count;
    }
    public double CalculateDensity()
    {
        return animalCount / area;
    }
}
