using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_07 : CardInfo
{
    public CardInfo_187_JA_07()
    {
        this.cardNo = "187_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "トゥクトゥク";
        this.cardName2 = "キュンキュンするほどキュート";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Resist2 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
