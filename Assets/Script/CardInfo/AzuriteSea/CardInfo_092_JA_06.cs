using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_06 : CardInfo
{
    public CardInfo_092_JA_06()
    {
        this.cardNo = "092_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "オリビア・フラバーシャム";
        this.cardName2 = "おもちゃ屋の娘";
        this.power = 1;
        this.toughness = 1;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.BrittneyHackett;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
