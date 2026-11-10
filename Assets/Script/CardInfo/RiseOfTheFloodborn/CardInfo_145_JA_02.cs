using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_02 : CardInfo
{
    public CardInfo_145_JA_02()
    {
        this.cardNo = "145_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒNƒ‹ƒGƒ‰";
        this.cardName2 = "‘Š•Ï‚í‚ç‚¸‚Ð‚Ç‚¢‚à‚Ì‚æ!";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GusGadgetAndLeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
