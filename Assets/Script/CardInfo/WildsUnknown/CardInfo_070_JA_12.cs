using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_070_JA_12 : CardInfo
{
    public CardInfo_070_JA_12()
    {
        this.cardNo = "070_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ヘイミッシュ＆ヒューバート＆ハリス";
        this.cardName2 = "やんちゃ三兄弟";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Prince};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
