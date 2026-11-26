using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_240_JA_14 : CardInfo
{
    public CardInfo_240_JA_14()
    {
        this.cardNo = "240_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ラーヤ";
        this.cardName2 = "決意の探検者";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
