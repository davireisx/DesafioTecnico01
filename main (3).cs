using System;
class HelloWorld {
  static void Main() {
    float seguidoresnovos = 150,seguidoresanterior = 200;
    int curtidasnovo = 100, curtidasanterior = 500;
    bool comeco = true;
    
    if (comeco == true) {
     
    Console.WriteLine("Bem vindo ao Instagram!");
    Console.WriteLine("Digite as seguintes informações: ");
    
    Console.Write("Nome de usuário: ");
    string usuario = Console.ReadLine();
    
    Console.Write("Senha: ");
    string senha = Console.ReadLine(); 
    
    
    if(senha == "thelastofus" && usuario == "elliewilliams") {
        
    Console.WriteLine("Parabéns, você se conectou a sua conta!");
    Console.WriteLine("Digite 1.0 para ver seus seguidores e 2.0 para ver suas curtidas.");
    int numeroescolhido = int.Parse (Console.ReadLine());

    if (numeroescolhido == 1.0 ) {
        
    double seguidoresfinal = seguidoresanterior + seguidoresnovos;
    
    Console.WriteLine($"O numero de seguidores atual é de {seguidoresfinal} ");
    }
    
    else if (numeroescolhido == 2.0 ) {
    double curtidasfinal= curtidasanterior + curtidasnovo;
    Console.WriteLine($"O numero de curtidas de seu vídeo atual é de {curtidasfinal} mil. ");
    }
    
}
    comeco = false;
}
  }
}

