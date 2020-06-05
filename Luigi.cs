namespace polimorfismo
{
    public class Luigi : player {
        public override void Pular(){
            //manter as açoes do metodo do pai
            base.Pular();
            //acrescentar uma ação
            System.Console.WriteLine("luigi esta pulando mais alto");
        }

        
    }
}