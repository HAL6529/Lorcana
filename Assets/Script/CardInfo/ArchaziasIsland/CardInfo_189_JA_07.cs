using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_07 : CardInfo
{
    public CardInfo_189_JA_07()
    {
        this.cardNo = "189_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉâÉYÅ[Éã";
        this.cardName2 = "Ç®Ç¡Ç©Ç»Ç¢âqï∫";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
