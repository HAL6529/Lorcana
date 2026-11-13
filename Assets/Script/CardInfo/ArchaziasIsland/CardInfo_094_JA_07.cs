using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_094_JA_07 : CardInfo
{
    public CardInfo_094_JA_07()
    {
        this.cardNo = "094_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "マッドハッター";
        this.cardName2 = "やりたい放題の奇人";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JohnLorenAndNicholasKole;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
