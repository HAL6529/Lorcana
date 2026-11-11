using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_220_JA_05 : CardInfo
{
    public CardInfo_220_JA_05()
    {
        this.cardNo = "220_JA_05";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "îíê·ïP";
        this.cardName2 = "îéà§Ç»ÇÈïPåN";
        this.power = 3;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.OttoSchmidt;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
