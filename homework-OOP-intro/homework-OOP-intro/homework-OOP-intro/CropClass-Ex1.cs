public class Crop
{
    string name;
    public enum cropStage
    {
        Seed=0,
        Sprout,
        Plant,
        CanBeHarvested,
        Harvested
    }
    public cropStage currentStage;
    public Crop(string name)
    {
        this.name = name;
        this.currentStage=cropStage.Seed;
    }
    public void Water()
    {
        if( this.currentStage== cropStage.CanBeHarvested)
        {
            throw new Exception("The crop is ready to be harvested");
        }
        else
        {
            this.currentStage = this.currentStage + 1;
        }
    }
    public void Harvest()
    {
        if (this.currentStage == cropStage.CanBeHarvested)
        {
            this.currentStage = cropStage.Harvested;
        }
    }
}
