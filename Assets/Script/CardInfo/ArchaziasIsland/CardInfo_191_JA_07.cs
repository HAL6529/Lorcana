using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_07 : CardInfo
{
    public CardInfo_191_JA_07()
    {
        this.cardNo = "191_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "チクタクワニ";
        this.cardName2 = "まちかまえているクロコダイル";
        this.power = 5;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
