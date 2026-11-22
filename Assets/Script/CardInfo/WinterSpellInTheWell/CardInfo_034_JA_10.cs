using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_10 : CardInfo
{
    public CardInfo_034_JA_10()
    {
        this.cardNo = "034_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ダックバーグ";
        this.cardName2 = "ファンゾーのファンゾーン";
        this.power = 2;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.NevenaNikolcheva;
        this.classList = new List<EnumController.Class> ();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
