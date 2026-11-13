using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_07 : CardInfo
{
    public CardInfo_017_JA_07()
    {
        this.cardNo = "017_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "キャンドルヘッド";
        this.cardName2 = "献身的なレーサー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
