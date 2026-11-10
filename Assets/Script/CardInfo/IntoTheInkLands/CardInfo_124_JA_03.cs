using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_03 : CardInfo
{
    public CardInfo_124_JA_03()
    {
        this.cardNo = "124_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "スライトリー";
        this.cardName2 = "ロスト・ボーイズ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LucaPinelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
