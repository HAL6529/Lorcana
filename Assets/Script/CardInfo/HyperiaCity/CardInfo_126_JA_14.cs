using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_126_JA_14 : CardInfo
{
    public CardInfo_126_JA_14()
    {
        this.cardNo = "126_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "トレメイン夫人";
        this.cardName2 = "高慢な気取り屋";
        this.power = 0;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ChemeneDeHeus;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
