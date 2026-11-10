using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_04 : CardInfo
{
    public CardInfo_010_JA_04()
    {
        this.cardNo = "010_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ƒKƒXƒgƒ“";
        this.cardName2 = "”Ú—ò‚ÈŽæˆø‘ŠŽè";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
