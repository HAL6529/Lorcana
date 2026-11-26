using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_14 : CardInfo
{
    public CardInfo_195_JA_14()
    {
        this.cardNo = "195_JA_14";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "シア・カーン";
        this.cardName2 = "カーン産業CEO";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AitorSebastian;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
