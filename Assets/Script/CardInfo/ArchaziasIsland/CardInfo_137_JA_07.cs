using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_07 : CardInfo
{
    public CardInfo_137_JA_07()
    {
        this.cardNo = "137_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉÄÅ[ÉVÉÖÅ[";
        this.cardName2 = "àÃëÂÇ»ÇÈó¥";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TomBancroft;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
