namespace Services;

public class ImcService
{
    public double Calcular(double peso, double altura)
    {
        if (peso <= 0 || altura <= 0)
            throw new ArgumentException("Peso e altura devem ser maiores que zero.");

        return Math.Round(peso / (altura * altura), 2);
    }
}
