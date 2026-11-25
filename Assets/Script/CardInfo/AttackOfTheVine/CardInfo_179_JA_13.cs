using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_13 : CardInfo
{
    public CardInfo_179_JA_13()
    {
        this.cardNo = "179_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "スプラウト";
        this.cardName2 = "試作品509号";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ChemeneDeHeus;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
