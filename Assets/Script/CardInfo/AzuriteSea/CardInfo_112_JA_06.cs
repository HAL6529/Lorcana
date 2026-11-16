using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_06 : CardInfo
{
    public CardInfo_112_JA_06()
    {
        this.cardNo = "112_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉAÉâÉWÉì";
        this.cardName2 = "ã∞ÇÍímÇÁÇ∏ÇÃçqäCém";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LavaHijzelaar;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
