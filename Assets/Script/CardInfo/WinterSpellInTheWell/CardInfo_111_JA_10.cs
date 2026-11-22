using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_10 : CardInfo
{
    public CardInfo_111_JA_10()
    {
        this.cardNo = "111_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "カトリーナ・ヴァン・タッセル";
        this.cardName2 = "バラ色のほっぺたの令嬢";
        this.power = 6;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CelesteJamneck;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheAdventuresOfIchabodAndMrToad;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
