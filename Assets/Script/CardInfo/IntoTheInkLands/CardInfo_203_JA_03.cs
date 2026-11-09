using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_203_JA_03 : CardInfo
{
    public CardInfo_203_JA_03()
    {
        this.cardNo = "203_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ノッティンガム";
        this.cardName2 = "プリンス・ジョンの城";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrynJones;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}
