using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_03 : CardInfo
{
    public CardInfo_082_JA_03()
    {
        this.cardNo = "082_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "ロスト・ボーイズのリーダー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
