using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_01 : CardInfo
{
    public CardInfo_171_JA_01()
    {
        this.cardNo = "171_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉAÉâÉWÉì";
        this.cardName2 = "í«Ç¢çûÇ‹ÇÍÇΩåïém";
        this.power = 2;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = "Randy Bishop";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
