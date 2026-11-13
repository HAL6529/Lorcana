using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_07 : CardInfo
{
    public CardInfo_049_JA_07()
    {
        this.cardNo = "049_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "イアーゴ";
        this.cardName2 = "ドデカいおばけオウム";
        this.power = 4;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JohnLorenAndNicholasKole;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Illusion };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Vanish };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
