using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_099_JA_07 : CardInfo
{
    public CardInfo_099_JA_07()
    {
        this.cardNo = "099_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ベルリオーズ";
        this.cardName2 = "いたずらキャット";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GeoffreyBoudout;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
