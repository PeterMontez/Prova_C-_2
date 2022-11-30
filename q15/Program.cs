using System.Linq;
using System.Collections.Generic;

App.Run();

public class Controller
{
    public void Solve(IEnumerable<Piece> pieces)
    {
        var inicial = pieces.First(p => p.IsLeftTopPiece());
        inicial.SetPosition(0, 0);
        var anterior = inicial;
        int i = 0;

        while (true)
        {
            var atual = anterior;
            for (int j = 0; j < 31; j++)
            {
                // Organizador horizontal
                foreach (var peca in pieces)
                {
                    if (atual.ConnectRight(peca))
                    {
                        atual = peca;
                        peca.SetPosition(j+1, i);
                        break;
                    }
                }
            }
            if (i == 17)
                break;
            
            // Quebra vertical
            foreach (var peca in pieces)
            {
                if (anterior.ConnectBottom(peca))
                {
                    anterior = peca;
                    peca.SetPosition(0, i+1);
                    break;
                }
            }
            i += 1;
        }
    }
}