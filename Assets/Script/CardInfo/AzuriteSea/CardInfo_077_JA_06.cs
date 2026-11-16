using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_06 : CardInfo
{
    public CardInfo_077_JA_06()
    {
        this.cardNo = "077_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ドーソン";
        this.cardName2 = "バジルのパートナー";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrittneyHackett;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
