public class Program {
    public static void main(String[] args) {
        var partner = new Partner.Partner();

        partner.talk();
        partner.insult();
        partner.kiss();
        partner.kiss();
        partner.talk();
        partner.kiss();
        partner.insult();
        partner.insult();

        // try to recover from SuperAngryState
        partner.kiss();
        partner.kiss();
        partner.kiss();
        partner.kiss();
        partner.kiss();
    }
}
