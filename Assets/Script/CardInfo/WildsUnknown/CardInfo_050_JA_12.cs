using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_12 : CardInfo
{
    public CardInfo_050_JA_12()
    {
        this.cardNo = "050_JA_12";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ヘイミッシュ＆ヒューバート＆ハリス";
        this.cardName2 = "いたずら三兄弟";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
