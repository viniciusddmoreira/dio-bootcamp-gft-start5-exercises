using FirstStepsWithDotNet;

Aluno[] alunos = new Aluno[5];
var indiceAluno = 0;
string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            var aluno = new Aluno();
            Console.WriteLine("Informe o nome do aluno: ");   
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno: ");
            if(decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
                throw new ArgumentException("O valor da nota deve ser decimal.");
            }

            alunos[indiceAluno] = aluno;
            indiceAluno++;

            break;
        case "2":
            foreach (var alunoListagem in alunos)
            {
                if (!string.IsNullOrEmpty(alunoListagem.Nome))
                {
                    Console.WriteLine($"ALUNO: {alunoListagem.Nome} - NOTA: {alunoListagem.Nota} ");

                }
            }
            break;
        case "3":
            decimal notaTotal = 0;
            var numeroAlunos = 0;

            for (int i = 0; i < alunos.Length; i++)
            {
                if (!string.IsNullOrEmpty(alunos[i].Nome))
                {
                    notaTotal = notaTotal + alunos[i].Nota;
                    numeroAlunos++;
                }
            }

            var mediaGeral = notaTotal / numeroAlunos;
            Conceito conceitoGeral;
            if (mediaGeral < 4)
            {
                conceitoGeral = Conceito.E;
            }
            else if (mediaGeral < 6)
            {
                conceitoGeral = Conceito.D;
            }
            else if (mediaGeral < 8)
            {
                conceitoGeral = Conceito.C;
            }
            else if (mediaGeral < 10)
            {
                conceitoGeral = Conceito.B;
            }
            else
            {
                conceitoGeral = Conceito.A;
            }
            Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    opcaoUsuario = ObterOpcaoUsuario();

}

static string ObterOpcaoUsuario()
{
    Console.WriteLine();
    Console.WriteLine("Informe a opção desejada: ");
    Console.WriteLine("1- Inserir novo aluno");
    Console.WriteLine("2- Listar alunos");
    Console.WriteLine("3- Calcular média geral dos alunos");
    Console.WriteLine("X- Sair");

    string opcaoUsuario = Console.ReadLine();
    return opcaoUsuario;
}