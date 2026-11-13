using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_07 : CardInfo
{
    public CardInfo_181_JA_07()
    {
        this.cardNo = "181_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ドクター・キャリコ";
        this.cardName2 = "緑の目の男";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
