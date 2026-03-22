using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcService;

public class ImcService
{
    public double Calcular(double peso, double altura)
    {
        if (peso <= 0 || altura <= 0)
            throw new ArgumentException("Peso e altura devem ser maiores que zero.");

        return Math.Round(peso / (altura * altura), 2);
    }
}
