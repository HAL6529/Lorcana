using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_215_JA_08 : CardInfo
{
    public CardInfo_215_JA_08()
    {
        this.cardNo = "215_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "フック船長";
        this.cardName2 = "海賊王";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
