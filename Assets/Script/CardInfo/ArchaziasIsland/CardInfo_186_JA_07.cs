using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_186_JA_07 : CardInfo
{
    public CardInfo_186_JA_07()
    {
        this.cardNo = "186_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉâÅ[ÉÑ";
        this.cardName2 = "ì±Ç´ÇãÅÇﬂÇµé“";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxineVee;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
