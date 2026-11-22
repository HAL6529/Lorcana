using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_236_JA_10 : CardInfo
{
    public CardInfo_236_JA_10()
    {
        this.cardNo = "236_JA_10";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "シンデレラ";
        this.cardName2 = "夢をかなえたプリンセス";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrittneyHackett;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
